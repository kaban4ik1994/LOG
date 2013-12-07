using System;


namespace File_Generator.Generator_Param
{
    class DateOfCreationOptions:CreationOptionsValue
    {
        public DateTime StartTime { get; set; }
        public int MinIntervalInMilliseconds { get; set; }
        public int MaxIntervalInMilliseconds { get; set; }
    }
}
