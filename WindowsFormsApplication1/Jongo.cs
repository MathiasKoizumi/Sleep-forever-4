using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Jongo
	{
		private Juklas biffy;

		private Form1 form1;

		private Jingo jin;

		private List<Jingo> john = new List<Jingo>();

		private BolleHeaven k;

		private List<Jingo> kusMig = new List<Jingo>();

		public Jongo(Form1 form)
		{
			form1 = form;
			jin = new Jingo(form1);
			fillList(new Jingo(form1));
			k = new BolleHeaven(john);
		}

		internal void blivHosMig(int p)
		{
			throw new NotImplementedException();
		}

		private BolleHeaven callJongo(int t)
		{
			k.bolledej(t, t + 12);
			return k;
		}

		internal List<Jingo> fillJoy(Jonga jonga)
		{
			for (int i = 0; i < jonga.getNumbing(4000); i++)
			{
				kusMig.Add(jin);
			}
			return kusMig;
		}

		public void fillList(Jingo troja)
		{
			for (int i = 0; i < 20; i++)
			{
				troja = troja.changeCourse();
				troja.moodChange(troja, biffy);
				john.Add(jin);
			}
		}

		public List<Jingo> getJohn()
		{
			return john;
		}
	}
}
