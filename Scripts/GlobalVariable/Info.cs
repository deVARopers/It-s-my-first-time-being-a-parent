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
        new PublicInfo("SleepBaby_1","Grip 버튼을 이용하여 속싸개를 집어주세요"),
        new PublicInfo("SleepBaby_2","아기를 향해 Grip버튼을 떼어 속싸개를 입히세요"),
        new PublicInfo("SleepBaby_3","Grip 버튼을 눌러 아기를 감싸 안으세요"),
        new PublicInfo("SleepBaby_4","아기의 등을 쓰다듬으세요"),
        new PublicInfo("SleepBaby_5","Grip버튼을 떼어 아기를 침대에 눕히세요")
    };

    public static PublicInfo[] Start = new PublicInfo[]
    {
        new PublicInfo("Start_1","왼손 Grab 버튼을 이용하여 아기를 안으세요"),
        new PublicInfo("Start_2","오른손 조이스틱을 위로 움직이세요"),
        new PublicInfo("Start_3","앞으로 계속 이동하세요"),
        new PublicInfo("Start_4","조이스틱을 왼쪽으로 움직이세요"),
        new PublicInfo("Start_5","왼손 Grab 버튼을 떼세요"),
        new PublicInfo("Start_6","Trigger 버튼을 이용하여 침대를 클릭하세요"),
        new PublicInfo("Start_7","Trigger 버튼을 이용하여 바디수트를 클릭하세요"),
        new PublicInfo("Start_8","Trigger 버튼을 이용하여 속싸개를 클릭하세요"),
        new PublicInfo("Start_9","Teleport를 이용하여 주방으로 이동하세요"),
        new PublicInfo("Start_10","Trigger 버튼을 이용하여 젖병을 클릭하세요"),
        new PublicInfo("Start_11","Trigger 버튼을 이용하여 분유통을 클릭하세요"),
        new PublicInfo("Start_12","Teleport를 이용하여 화장실로 이동하세요"),
        new PublicInfo("Start_13","Trigger 버튼을 이용하여 다이퍼체인저를 클릭하세요"),
        new PublicInfo("Start_14","Trigger 버튼을 이용하여 물티슈를 클릭하세요"),
        new PublicInfo("Start_15","Trigger 버튼을 이용하여 기저귀를 클릭하세요"),
        new PublicInfo("Start_16","Teleport를 이용하여 침대로 이동하세요"),
    };

    public static PublicInfo[] Wash = new PublicInfo[]
   {
        new PublicInfo("Wash_1","Grib 버튼을 눌러 아기의 옷을 벗기세요"),
        new PublicInfo("Wash_2","Trigger 버튼을 눌러 기저귀를 푸세요"),
        new PublicInfo("Wash_3","Grib 버튼을 눌러 아기의 양 발목을 잡으세요"),
        new PublicInfo("Wash_4","Grib 버튼을 눌러 아기의 기저귀를 빼세요"),
        new PublicInfo("Wash_5","Grib 버튼을 눌러 물티슈를 집으세요"),
        new PublicInfo("Wash_6","물티슈로 대변을 닦으세요"),
        new PublicInfo("Wash_7","Grib 버튼으로 아기를 안고 화장실로 가세요"),
        new PublicInfo("Wash_8","Grib 버튼을 떼어 아기를 세면대에 위치시키세요"),
        new PublicInfo("Wash_9","Trigger 버튼을 눌러 물을 트세요"),
        new PublicInfo("Wash_10","Grib 버튼으로 물을 움켜쥐세요"),
        new PublicInfo("Wash_11","표시된 위치에 Grib 버튼을 떼서 물을 흘려보세요"),
        new PublicInfo("Wash_12","아기의 엉덩이가 깨끗해질 때까지 반복하세요"),
        new PublicInfo("Wash_13","Grib 버튼으로 손수건을 집으세요"),
        new PublicInfo("Wash_14","손수건으로 엉덩이의 물기를 닦으세요"),
        new PublicInfo("Wash_15","Grib 버튼으로 아기를 안으세요"),
        new PublicInfo("Wash_16","Grib 버튼을 떼어 아기를 눕히세요"),
        new PublicInfo("Wash_17","Grib 버튼을 눌러 새 기저귀를 잡아 아기 밑에 펼치세요"),
        new PublicInfo("Wash_18","다리를 잡고 있던 Grib 버튼을 떼어 다리를 놓으세요"),
        new PublicInfo("Wash_19","Trigger 버튼을 눌러 기저귀를 채우세요"),
        new PublicInfo("Wash_20","Grib 버튼을 눌러 아기의 옷을 집으세요"),
        new PublicInfo("Wash_21","아기에게 옷을 입히세요"),
        new PublicInfo("Wash_22","Grib 버튼으로 아기를 안고 침대로 가세요"),
        new PublicInfo("Wash_23","Grib 버튼을 떼서 아기를 침대에 눕히세요"),
        new PublicInfo("Wash_24","Grib 버튼을 눌러 속싸개를 집으세요"),
        new PublicInfo("Wash_25","아기를 향해 Grib 버튼을 떼어 속싸개를 입히세요"),
   };

    public static PublicInfo[] Pee = new PublicInfo[]
   {
        new PublicInfo("diaper_1","Grib 버튼을 눌러 아기의 옷을 벗기세요"),
        new PublicInfo("diaper_2","기저귀에 컨트롤러를 Hover 해서 상태를 확인하세요"),
        new PublicInfo("diaper_3","Trigger 버튼을 눌러 기저귀를 푸세요"),
        new PublicInfo("diaper_4","Grib 버튼을 눌러 아기의 양 발목을 잡으세요"),
        new PublicInfo("diaper_5","Grib 버튼을 눌러 아기의 기저귀를 빼세요"),
        new PublicInfo("diaper_6","Grib 버튼을 눌러 물티슈를 집으세요"),
        new PublicInfo("diaper_7","물티슈로 소변을 닦으세요"),
        new PublicInfo("diaper_8","엉덩이가 건조될 때까지 잠시 기다리세요"),
        new PublicInfo("diaper_9","Grib 버튼을 눌러 새 기저귀를 잡아 아기 밑에 펼치세요"),
        new PublicInfo("diaper_10","다리를 잡고 있던 Grib 버튼을 떼어 다리를 놓으세요"),
        new PublicInfo("diaper_11","Trigger 버튼을 눌러 기저귀를 채우세요"),
        new PublicInfo("diaper_12","Grib 버튼을 눌러 아기의 옷을 집으세요"),
        new PublicInfo("diaper_13","아기에게 옷을 입히세요"),
   };

    public static PublicInfo[] Transfer = new PublicInfo[]
   {
        new PublicInfo("Transfer_1","Grib 버튼으로 아기를 안고 침대로 가세요"),
        new PublicInfo("Transfer_2","Grib 버튼을 떼어 아기를 침대에 눕히세요"),
        new PublicInfo("Transfer_3","Grib 버튼을 눌러 속싸개를 집으세요"),
        new PublicInfo("Transfer_4","아기를 향해 Grib 버튼을 떼어 속싸개를 입히세요"),
   };

    public static PublicInfo[] TransferToBath = new PublicInfo[]
{
        new PublicInfo("TransferBath_1","Grib 버튼으로 아기를 안고 화장실로 가세요"),
        new PublicInfo("TransferBath_2","Grib 버튼을 떼어 아기를 다이퍼 체인저에 눕히세요"),
};
    public static PublicInfo[] Nursing = new PublicInfo[]
   {
        new PublicInfo("Nursing_1","아기의 입에 컨트롤러를 갖다 대세요"),
        new PublicInfo("Nursing_2","주방으로 이동하세요"),
        new PublicInfo("Nursing_3","Grib 버튼을 눌러 수저를 잡고 분유를 젖병 위에서 기울여주세요"),
        new PublicInfo("Nursing_4","Grib 버튼을 눌러 젖병과 막대를 잡고 분유를 섞어주세요"),
        new PublicInfo("Nursing_5","Grib 버튼을 눌러 뚜껑을 잡고 젖병 위에 놓으세요"),
        new PublicInfo("Nursing_6","젖병을 놓고 아기 침대 앞으로 이동하세요"),
        new PublicInfo("Nursing_7","Grib 버튼을 눌러 아기를 안아주세요"),
        new PublicInfo("Nursing_8","Grib 버튼을 눌러 젖병을 잡아주세요"),
        new PublicInfo("Nursing_9","젖병을 아기 입에 물려 수유하세요"),
        new PublicInfo("Nursing_10","컨트롤러로 아기 등을 쓰다듬어 주세요"),
        new PublicInfo("Nursing_11","계속해서 쓰다듬어 주세요"),
        new PublicInfo("Nursing_12","아기 침대로 이동해주세요"),
        new PublicInfo("Nursing_13","Grip 버튼을 떼어 아기를 침대에 눕히세요."),
        new PublicInfo("Nursing_14","수유 시뮬레이션이 종료되었습니다."),
   };

}
