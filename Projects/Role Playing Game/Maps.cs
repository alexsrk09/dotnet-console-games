﻿namespace Role_Playing_Game
{
	public static class Maps
	{
		public static readonly char[][] Town = new char[][]
		{
			// X: player start position
			// 1: field (switches map to Field)
			// b: building
			// B: barrels
			// c: chest
			// f: fence
			// i: inn
			// s: store
			// w: water
			// W: wall
			"   WWWWWWWWWWWWWWWWW111WWWWWWWWWWWWWWWWW   ".ToCharArray(),
			"wwwWbbbfbbbB             Bbffbffbffb  cWwww".ToCharArray(),
			"wwwW                                   Wwww".ToCharArray(),
			"wwwW     Bbfb                          Wwww".ToCharArray(),
			"wwwWcb                          BbbbB  Wwww".ToCharArray(),
			"wwwW           Bi    c    sB           Wwww".ToCharArray(),
			"wwwW                                  cWwww".ToCharArray(),
			"wwwWb   T            X           BbfbfbWwww".ToCharArray(),
			"wwwW                                  cWwww".ToCharArray(),
			"wwwWbffbfbffbfbfbbfb   bbfbfbffbfbbfbfbWwww".ToCharArray(),
			"   WWWWWWWWWWWWWWWWW111WWWWWWWWWWWWWWWWW   ".ToCharArray(),
			// out of bounds: open
		};

		public static readonly char[][] Field = new char[][]
		{
			// 0: town (switches map to Town)
			// 2: castle (switches map to Castle)
			// c: chest
			// g: guard (mini boss)
			// m: mountain
			// p: mountain
			// t: tree
			// w: water
			"mmmpmmmmpmmmmmpmmmmmpmmmmmpmmmpmmmpmmmpmm".ToCharArray(),
			"mmpppppppmmmpppmmmpppppmmppmmmpmmmmpppmmm".ToCharArray(),
			"mmpmmpmmpmppmmpmpmmpmmpmmmmmmpppmmpmpmmmp".ToCharArray(),
			"TTTTTc     mpmmc    TT           m2mcmmpp".ToCharArray(),
			"TTTT        mm                    g   mmm".ToCharArray(),
			"TTT   TT                 mm           mpm".ToCharArray(),
			"TTT           TTT      mmmm     TT    ppm".ToCharArray(),
			"www      T              mm     TTT    www".ToCharArray(),
			"www          TT    ww           T     www".ToCharArray(),
			"www                 ww  TTT         wwwww".ToCharArray(),
			"www   w0w      Tww                 mmmmmm".ToCharArray(),
			"wwww          wwwwwww      TT   cmmmmmmmm".ToCharArray(),
			"wwwwwwwwwwwwwwwwwwwwwTTTTTTTTTTTTmmmmmmmm".ToCharArray(),
			"wwwwwwwwwwwwwwwwwwwwTTTTTTTTTTTTTTmmmmmmm".ToCharArray(),
			"wwwwwwwwwwwwwwwwwwwTTTTTTTTTTTTTTTTmmmmmm".ToCharArray(),
			// out of bounds: mountain
		};

		public static readonly char[][] Castle = new char[][]
		{
			// 1: arrow (switches map to Field)
			// c: chest
			// m: mountain
			// t: tree
			// W: wall
			// k: final boss (boss)
			"WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW".ToCharArray(),
			"WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW".ToCharArray(),
			"WWc                WkW                cWW".ToCharArray(),
			"WW                 W W                 WW".ToCharArray(),
			"WW                                     WW".ToCharArray(),
			"WW       W      W       W      W       WW".ToCharArray(),
			"WW                                     WW".ToCharArray(),
			"WW                                     WW".ToCharArray(),
			"WW       W      W       W      W       WW".ToCharArray(),
			"WW                                     WW".ToCharArray(),
			"WW                                     WW".ToCharArray(),
			"WW       W      W       W      W       WW".ToCharArray(),
			"WW                                     WW".ToCharArray(),
			"WWc                                   cWW".ToCharArray(),
			"WWWWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWW".ToCharArray(),
			"WWWWWWWWWWWWWWWWWWW111WWWWWWWWWWWWWWWWWWW".ToCharArray(),
			//out of bounds: open
		};
	}
}