using System;

namespace AnimalApp.Models

{
    public interface IVoiceCapable
    {
        event EventHandler VoiceGiven;

        void GiveVoice();
    }
}