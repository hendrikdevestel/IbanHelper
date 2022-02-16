using IbanHelper.Validators;
using System;

namespace IbanHelper
{
    public static class IbanValidator
    {
        public static void IsValidNumber(string input)
        {
            //if length > 34 : invalid length
            //If contains special chars: invalid format
            //validate first 2 letters: country code
            //next 2 numbers
            //then max 30 letters and numbers
            var belfius = "BE86 063 6 8972 0050";
            var belfius2 = "BE65 779 5 9468 4196";
            var belfius3 = "BE75 083 8 0532 7951";
            var belfius4 = "BE32 833 4 6516 7002";
            var keyTrade = "BE11 651 16519 5248";
            var keyTrade2 = "BE19 6512 7486 9512";
            var keyTrade3 = "BE19 6512 7486 9515";

            var belgium = new Belgium();
            var b1 = belgium.Validate(belfius);
            var b2 = belgium.Validate(belfius2);
            var b3 = belgium.Validate(belfius3);
            var b4 = belgium.Validate(belfius4);
            var k1 = belgium.Validate(keyTrade);
            var k2 = belgium.Validate(keyTrade2);
            var k3 = belgium.Validate(keyTrade3);

        }
    }
}
