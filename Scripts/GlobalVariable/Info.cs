using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Info 
{
    public class PublicInfo
    {
        private string gvState;
        private string infoText;

        public PublicInfo(string state, string info)
        {
            this.gvState = state;
            this.infoText = info;
        }

        public string GVState
        {
            get { return gvState; }
            set { gvState = value; }
        }
        public string InfoText
        {
            get { return infoText; }
            set { infoText = value; }
        }
    }

    public static PublicInfo[] BabySleep = new PublicInfo[]
    {
        new PublicInfo("SleepBaby_1","Grip ��ư�� �̿��Ͽ� �ӽΰ��� �����ּ���"),
        new PublicInfo("SleepBaby_2","�Ʊ⸦ ���� Grip��ư�� ���� �ӽΰ��� ��������"),
        new PublicInfo("SleepBaby_3","Grip ��ư�� ���� �Ʊ⸦ ���� ��������"),
        new PublicInfo("SleepBaby_4","�Ʊ��� ���� ���ٵ�������"),
        new PublicInfo("SleepBaby_5","Grip��ư�� ���� �Ʊ⸦ ħ�뿡 ��������")
    };

    public static PublicInfo[] Start = new PublicInfo[]
    {
        new PublicInfo("Start_1","�޼� Grab ��ư�� �̿��Ͽ� �Ʊ⸦ ��������"),
        new PublicInfo("Start_2","������ ���̽�ƽ�� ���� �����̼���"),
        new PublicInfo("Start_3","������ ��� �̵��ϼ���"),
        new PublicInfo("Start_4","���̽�ƽ�� �������� �����̼���"),
        new PublicInfo("Start_5","�޼� Grab ��ư�� ������"),
        new PublicInfo("Start_6","Trigger ��ư�� �̿��Ͽ� ħ�븦 Ŭ���ϼ���"),
        new PublicInfo("Start_7","Trigger ��ư�� �̿��Ͽ� �ٵ��Ʈ�� Ŭ���ϼ���"),
        new PublicInfo("Start_8","Trigger ��ư�� �̿��Ͽ� �ӽΰ��� Ŭ���ϼ���"),
        new PublicInfo("Start_9","Teleport�� �̿��Ͽ� �ֹ����� �̵��ϼ���"),
        new PublicInfo("Start_10","Trigger ��ư�� �̿��Ͽ� ������ Ŭ���ϼ���"),
        new PublicInfo("Start_11","Trigger ��ư�� �̿��Ͽ� �������� Ŭ���ϼ���"),
        new PublicInfo("Start_12","Teleport�� �̿��Ͽ� ȭ��Ƿ� �̵��ϼ���"),
        new PublicInfo("Start_13","Trigger ��ư�� �̿��Ͽ� ������ü������ Ŭ���ϼ���"),
        new PublicInfo("Start_14","Trigger ��ư�� �̿��Ͽ� ��Ƽ���� Ŭ���ϼ���"),
        new PublicInfo("Start_15","Trigger ��ư�� �̿��Ͽ� �����͸� Ŭ���ϼ���"),
        new PublicInfo("Start_16","Teleport�� �̿��Ͽ� ħ��� �̵��ϼ���"),
    };

    public static PublicInfo[] Wash = new PublicInfo[]
   {
        new PublicInfo("Wash_1","Grib ��ư�� ���� �Ʊ��� ���� ���⼼��"),
        new PublicInfo("Wash_2","Trigger ��ư�� ���� �����͸� Ǫ����"),
        new PublicInfo("Wash_3","Grib ��ư�� ���� �Ʊ��� �� �߸��� ��������"),
        new PublicInfo("Wash_4","Grib ��ư�� ���� �Ʊ��� �����͸� ������"),
        new PublicInfo("Wash_5","Grib ��ư�� ���� ��Ƽ���� ��������"),
        new PublicInfo("Wash_6","��Ƽ���� �뺯�� ��������"),
        new PublicInfo("Wash_7","Grib ��ư���� �Ʊ⸦ �Ȱ� ȭ��Ƿ� ������"),
        new PublicInfo("Wash_8","Grib ��ư�� ���� �Ʊ⸦ ����뿡 ��ġ��Ű����"),
        new PublicInfo("Wash_9","Trigger ��ư�� ���� ���� Ʈ����"),
        new PublicInfo("Wash_10","Grib ��ư���� ���� �����㼼��"),
        new PublicInfo("Wash_11","ǥ�õ� ��ġ�� Grib ��ư�� ���� ���� ���������"),
        new PublicInfo("Wash_12","�Ʊ��� �����̰� �������� ������ �ݺ��ϼ���"),
        new PublicInfo("Wash_13","Grib ��ư���� �ռ����� ��������"),
        new PublicInfo("Wash_14","�ռ������� �������� ���⸦ ��������"),
        new PublicInfo("Wash_15","Grib ��ư���� �Ʊ⸦ ��������"),
        new PublicInfo("Wash_16","Grib ��ư�� ���� �Ʊ⸦ ��������"),
        new PublicInfo("Wash_17","Grib ��ư�� ���� �� �����͸� ��� �Ʊ� �ؿ� ��ġ����"),
        new PublicInfo("Wash_18","�ٸ��� ��� �ִ� Grib ��ư�� ���� �ٸ��� ��������"),
        new PublicInfo("Wash_19","Trigger ��ư�� ���� �����͸� ä�켼��"),
        new PublicInfo("Wash_20","Grib ��ư�� ���� �Ʊ��� ���� ��������"),
        new PublicInfo("Wash_21","�Ʊ⿡�� ���� ��������"),
        new PublicInfo("Wash_22","Grib ��ư���� �Ʊ⸦ �Ȱ� ħ��� ������"),
        new PublicInfo("Wash_23","Grib ��ư�� ���� �Ʊ⸦ ħ�뿡 ��������"),
        new PublicInfo("Wash_24","Grib ��ư�� ���� �ӽΰ��� ��������"),
        new PublicInfo("Wash_25","�Ʊ⸦ ���� Grib ��ư�� ���� �ӽΰ��� ��������"),
   };

    public static PublicInfo[] Pee = new PublicInfo[]
   {
        new PublicInfo("diaper_1","Grib ��ư�� ���� �Ʊ��� ���� ���⼼��"),
        new PublicInfo("diaper_2","�����Ϳ� ��Ʈ�ѷ��� Hover �ؼ� ���¸� Ȯ���ϼ���"),
        new PublicInfo("diaper_3","Trigger ��ư�� ���� �����͸� Ǫ����"),
        new PublicInfo("diaper_4","Grib ��ư�� ���� �Ʊ��� �� �߸��� ��������"),
        new PublicInfo("diaper_5","Grib ��ư�� ���� �Ʊ��� �����͸� ������"),
        new PublicInfo("diaper_6","Grib ��ư�� ���� ��Ƽ���� ��������"),
        new PublicInfo("diaper_7","��Ƽ���� �Һ��� ��������"),
        new PublicInfo("diaper_8","�����̰� ������ ������ ��� ��ٸ�����"),
        new PublicInfo("diaper_9","Grib ��ư�� ���� �� �����͸� ��� �Ʊ� �ؿ� ��ġ����"),
        new PublicInfo("diaper_10","�ٸ��� ��� �ִ� Grib ��ư�� ���� �ٸ��� ��������"),
        new PublicInfo("diaper_11","Trigger ��ư�� ���� �����͸� ä�켼��"),
        new PublicInfo("diaper_12","Grib ��ư�� ���� �Ʊ��� ���� ��������"),
        new PublicInfo("diaper_13","�Ʊ⿡�� ���� ��������"),
   };

    public static PublicInfo[] Transfer = new PublicInfo[]
   {
        new PublicInfo("Transfer_1","Grib ��ư���� �Ʊ⸦ �Ȱ� ħ��� ������"),
        new PublicInfo("Transfer_2","Grib ��ư�� ���� �Ʊ⸦ ħ�뿡 ��������"),
        new PublicInfo("Transfer_3","Grib ��ư�� ���� �ӽΰ��� ��������"),
        new PublicInfo("Transfer_4","�Ʊ⸦ ���� Grib ��ư�� ���� �ӽΰ��� ��������"),
   };

    public static PublicInfo[] TransferToBath = new PublicInfo[]
{
        new PublicInfo("TransferBath_1","Grib ��ư���� �Ʊ⸦ �Ȱ� ȭ��Ƿ� ������"),
        new PublicInfo("TransferBath_2","Grib ��ư�� ���� �Ʊ⸦ ������ ü������ ��������"),
};
    public static PublicInfo[] Nursing = new PublicInfo[]
   {
        new PublicInfo("Nursing_1","�Ʊ��� �Կ� ��Ʈ�ѷ��� ���� �뼼��"),
        new PublicInfo("Nursing_2","�ֹ����� �̵��ϼ���"),
        new PublicInfo("Nursing_3","Grib ��ư�� ���� ������ ��� ������ ���� ������ ��￩�ּ���"),
        new PublicInfo("Nursing_4","Grib ��ư�� ���� ������ ���븦 ��� ������ �����ּ���"),
        new PublicInfo("Nursing_5","Grib ��ư�� ���� �Ѳ��� ��� ���� ���� ��������"),
        new PublicInfo("Nursing_6","������ ���� �Ʊ� ħ�� ������ �̵��ϼ���"),
        new PublicInfo("Nursing_7","Grib ��ư�� ���� �Ʊ⸦ �Ⱦ��ּ���"),
        new PublicInfo("Nursing_8","Grib ��ư�� ���� ������ ����ּ���"),
        new PublicInfo("Nursing_9","������ �Ʊ� �Կ� ���� �����ϼ���"),
        new PublicInfo("Nursing_10","��Ʈ�ѷ��� �Ʊ� ���� ���ٵ�� �ּ���"),
        new PublicInfo("Nursing_11","����ؼ� ���ٵ�� �ּ���"),
        new PublicInfo("Nursing_12","�Ʊ� ħ��� �̵����ּ���"),
        new PublicInfo("Nursing_13","Grip ��ư�� ���� �Ʊ⸦ ħ�뿡 ��������."),
        new PublicInfo("Nursing_14","���� �ùķ��̼��� ����Ǿ����ϴ�."),
   };

}
