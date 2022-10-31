//Benjamin Lefebvre - 301234598

using System;
namespace Benjamin_A3
{
	public class Consumer
	{
		public string ConsumerID { get; }
		public string Name { get; }

		public Consumer(string id, string name)
		{
			this.ConsumerID = id;
			this.Name = name;
		}

        public override string ToString()
        {
            return $"{this.ConsumerID,-16} {this.Name,-18}";
        }
    }
}

