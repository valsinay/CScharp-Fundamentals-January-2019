﻿namespace _04.OnlineRadio.Exceptions
{
  public  class InvalidSongSecondsException :InvalidSongLengthException
    {
        public override string Message => "Song seconds should be between 0 and 59.";
    }
}
