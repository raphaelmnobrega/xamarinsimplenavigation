using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace xamarinsimplenavigation.ViewModels.Base
{
	public class ViewModelBase : INotifyPropertyChanged
	{		

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisedPropertyChanged<T>(Expression<Func<T>> expression)
		{
			var member = expression.Body as MemberExpression;
			var propertyInfo = member.Member as PropertyInfo;

			if (propertyInfo != null)
			{
				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs(propertyInfo.Name));
				}
			}
		}
	}
}

