using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace BizLogic.GenericInterfaces
{
    public abstract class BizActionErrors
    {
        //Holds the list of validation errors privately
        private readonly List<ValidationResult> _errors = new List<ValidationResult>();

        //Provides a public, immutable list of errors
        public IImmutableList<ValidationResult> Errors => _errors.ToImmutableList();

        //Creates a bool HasErrors to make checking for errors easier
        public bool HasErrors => _errors.Any();

        //Allows a simple error message or an error message with properties linked to it, 
        //to be added to the errors list.

        public void AddError(string errorMessage, params string[] propertyNames)
        {
            _errors.Add(new ValidationResult(errorMessage, propertyNames));
        }
    }
}
