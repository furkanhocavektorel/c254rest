namespace obs.dto
{
    public class BaseResponseDto<T>
    {
        public int Code { get; set; } = 20230;
        public string Message { get; set; } = "ok";
        public T? Data { get; set; }

        public BaseResponseDto(T data)
        {
            this.Data = data;
        }

        public BaseResponseDto()
        {
        }

        public static BaseResponseDto<T> Success(T data)
        {
            BaseResponseDto<T> response = new BaseResponseDto<T>();
            response.Code = 20230;
            response.Message = "ok";
            response.Data = data;
            return response;
        }
        // 

        public static BaseResponseDto<T> Success(T data,int code,string message)
        {
            BaseResponseDto<T> response = new BaseResponseDto<T>();
            response.Code = code;
            response.Message = message;
            response.Data = data;
            return response;
        }

    }
}
