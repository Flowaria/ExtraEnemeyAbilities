﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraEnemyAbilities
{
    public static class Log
    {
        public static void Debug(object msg)
        {
            ExtraEnemyAbilities.log.LogDebug(msg);
        }

        public static void Error(object msg)
        {
            ExtraEnemyAbilities.log.LogError(msg);
        }

    }
}
