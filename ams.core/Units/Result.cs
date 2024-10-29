namespace ams.core.Units
{
    public class Result
    {
        public class ViewResult
        {
            public bool IsSucceed { get; set; }
            public string Statuses { get; set; } = null!;
            public string Message { get; set; } = null!;
            public string Key { get; set; } = null!;
            public string Token { get; set; } = null!;
        }

        public class ViewResult<T>
        {
            public T? View { get; set; }
            public bool IsSucceed { get; set; }
            public string Statuses { get; set; } = null!;
            public string Message { get; set; } = null!;
        }

        public class ListResult<T>
        {
            public List<T>? ListView { get; set; }
            public bool IsSucceed { get; set; }
            public string Statuses { get; set; } = null!;
            public string Message { get; set; } = null!;
        }
    }
}
