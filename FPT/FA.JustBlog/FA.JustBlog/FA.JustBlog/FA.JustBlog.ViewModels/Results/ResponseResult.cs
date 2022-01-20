namespace FA.JustBlog.ViewModels.Results
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            IsSucceed = true;
        }

        public ResponseResult(string errorMessage)
        {
            IsSucceed = false;
            ErrorMessage = errorMessage;
        }

        public bool IsSucceed { get; set; }
        public string ErrorMessage { get; set; }
    }
}
