namespace RegistroPersonal.Validation.IValidation
{
  interface IComponent<T>
  {
    public T Validate(); 
  }
}