namespace BookStore.Core.Utilities.Commands.Implementatinos
{
    public class ErrorItem
    {
        #region ctor
        public ErrorItem(string error)
        {
            Error = error;
        }
        #endregion

        #region props
        
        public string Error { get; set; }

        #endregion

        #region helpers

        public static ErrorItem Create(string error)
        {
            return new ErrorItem(error);
        }

        #endregion
    }
}