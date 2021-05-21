namespace BookStore.Core.Utilities.Commands.Implementatinos
{
    public class ErrorItem
    {
        #region ctor
        public ErrorItem(string controlName, string error)
        {
            ControlName = controlName;
            Error = error;
        }
        #endregion

        #region props
        
        public string ControlName { get; set; }
        public string Error { get; set; }

        #endregion

        #region helpers

        public static ErrorItem Create(string error)
        {
            return new ErrorItem(null, error);
        }

        public static ErrorItem Create(string control, string error)
        {
            return new ErrorItem(control, error);
        }

        #endregion
    }
}