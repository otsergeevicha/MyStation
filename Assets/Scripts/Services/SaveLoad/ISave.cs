﻿using Infrastructure.SaveLoadModule;

namespace Services.SaveLoad
{
    public interface ISave
    {
        Progress AccessProgress();
        void Save();
    }
}