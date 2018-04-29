using System;
using System.Text;

namespace Strategy 
{
    public class Hero : Human
    {
        static int MAX_WRIST_GADGETS_COUNT = 2;
        static int MAX_BELT_GADGETS_COUNT = 5;

        WristGadget[] wristGadgets;
        BeltGadget[] beltGadgets;
        HeadGadget headGadget;

        public Hero()
        {
            wristGadgets = new WristGadget[MAX_WRIST_GADGETS_COUNT];
            beltGadgets = new BeltGadget[MAX_BELT_GADGETS_COUNT];
        }

        public void SetHeadGadget(HeadGadget headGadget)
        {
            this.headGadget = headGadget;
        }

        public void UseHeadGadget()
        {
            headGadget.DoHeadAction();
        }

        public void SetWristGadget(int index, WristGadget wristGadget)
        {
            if(index < 0 || index >= MAX_WRIST_GADGETS_COUNT)
                return;

            this.wristGadgets[index] = wristGadget;
        }

        public void UseWristGadget(int index)
        {
            if(index < 0 || index >= MAX_WRIST_GADGETS_COUNT)
                return;

            wristGadgets[index].Send();;
        }

        public void SetBeltGadget(int index, BeltGadget beltGadget)
        {
            if(index < 0 || index >= MAX_BELT_GADGETS_COUNT)
                return;

            this.beltGadgets[index] = beltGadget;
        }
        
        public void UseBeltGadget(int index)
        {
            if(index < 0 || index >= MAX_BELT_GADGETS_COUNT)
                return;

            beltGadgets[index].DoAction();;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("\n\tGadgets : ");

            sb.Append($"\n\t\tTête : {headGadget}");

            sb.Append($"\n\t\tPoignets : ");
            for (int i = 0; i < MAX_WRIST_GADGETS_COUNT; i++)
                sb.Append($"\n\t\t\t{wristGadgets[i]}");

            sb.Append($"\n\t\tCeinture : ");
            for (int i = 0; i < MAX_BELT_GADGETS_COUNT; i++)
                sb.Append($"\n\t\t\t{beltGadgets[i]}");

            return base.ToString() + sb.ToString();
        }

    }
}