

namespace xamarinsimplenavigation.ViewModels.Base
{
	public class TypedViewModelBase<T> : ViewModelBase
		where T : class, new()
	{
		private T _entity;

		T Entity
		{
			get { return _entity; }
			set
			{
				_entity = value;
				RaisedPropertyChanged(() => Entity);
			}
		}

		public TypedViewModelBase()
		{
			Entity = new T();
		}
	}
}

