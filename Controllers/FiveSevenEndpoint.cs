using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BryantAMiniChallenge5_7_Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class fiveSevenEndPointController : ControllerBase
    {
        [HttpGet("/madLib")]
        public string madLib(string nounDino, string nounPet, string planetName, string food, string nounCity, string adjective){
            return $"The hungry {nounDino} and {nounPet} roamed the warm planet of {planetName} in search of fresh {food}. Eventually they were taken down to the paradise city of {nounCity}, where the weather felt {adjective} and the other animals were pretty. The End.";
        }

        [HttpGet("/oddOrEven")]
        public string oddOrEven(int a){ 
            string result;
            if(a%2 == 1){
                result = "odd";
            }
            else{
                result = "even";
            }
            return $"Your number is {result}.";
        }

        [HttpGet("/reverseItAlpha")]
        public string reverseItAlpha(string reverseItAlpha){
            char[] charArray = reverseItAlpha.ToCharArray();
            Array.Reverse(charArray);
            reverseItAlpha = new string(charArray);
            return $"Your reversed string is {reverseItAlpha}";
        }

        [HttpGet("/reverseItNum")]
        public string reverseItNum (int reverseNum ){
            int ogNum = reverseNum;
            int reverse = 0;   
            int remainder = 0;
            while( reverseNum > 0){
                remainder = reverseNum %10;
                reverseNum = reverseNum/10;
                reverse = (reverse*10) + remainder;
            }
                return $"You started with the number {ogNum}. Reverse it and you get {reverse}!";
            
        }
    }
}