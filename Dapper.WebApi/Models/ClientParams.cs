using System.ComponentModel.DataAnnotations;

namespace Dapper.WebApi
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientParams
    {
        /// <summary>
        /// 
        /// </summary>

        [EmailAddress(ErrorMessage ="Email not in Correct Format")]
        public string emailText { get; set; }
    }
}