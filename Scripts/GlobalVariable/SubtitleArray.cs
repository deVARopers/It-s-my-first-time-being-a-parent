using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SubtitleArray
{
    public static string[][] StartSubtitle = new string[11][] {
        //Start_1
        new string[] { "환영합니다! 드디어 집에 오셨네요!",
        "3주간의 산후조리원을 마치고 오시느라 고생 많으셨어요.",
        "왼손 Grib 버튼을 눌러 아기를 안으세요."},
        //Start_2
        new string[] {
        "떨어뜨리지 않도록 그립 버튼을 꾹 눌러주셔야 해요.",
        "집에 도착했으니 우선 아기를 침대에 눕힐까요?",
        "조이스틱을 위로 움직여 앞으로 이동해보세요."},
        //Start_3
        new string[] {
        "잘하셨어요! 앞으로 조금 더 이동하여 거실로 가보세요."},
        //Start_4
        new string[] {
        "조이스틱을 좌우로 움직이면 시점을 변경할 수 있어요.",
        "왼쪽으로 조이스틱을 움직여볼까요?",
        "조이스틱을 움직여 아기의 침대 쪽으로 이동해보세요."},
        //Start_5
        new string[] {
        "Grib 버튼을 떼어 아기를 침대에 눕히세요."},
        //Start_6
        new string[] {
        "아기를 눕혔으니 집에 필요한 물품들이 준비되어 있는지 확인해볼까요?",
        "주황색으로 반짝이는 물체를 트리거로 클릭하세요!"},
        //StartSubtitle[6] : Start_9
        new string[] {
        "참 잘하셨어요! 다음엔 부엌으로 넘어가보아요"},
        //StartSubtitle[7] : Start_10
        new string[] {
        "다음 필요한 물품을 알아볼까요.",
        "주황색으로 반짝이는 물체를 트리거로 클릭하세요!"},
        //StartSubtitle[8] : Start_12
        new string[] {
        "좋아요! 다음엔 화장실로 가보세요."},
        //StartSubtitle[9] : Start_13
        new string[]
        {"화장실에서는 아기의 기저귀를 갈아줄거에요.",
        "주황색으로 반짝이는 물체를 트리거로 클릭하세요!"},
        //StartSubtitle[10] : Start_16
        new string[]
        {"준비해야하는 물건들을 다 확인하였어요!", 
         "지금까지 살펴본 물품들은 육아시 필수적인 용품이에요.",
        "아기가 울고 있네요.",
        "울고있는 아기를 달래러 침대로 이동해볼까요."}
    };

    public static string[][] BabySleepSubtitle = new string[6][] {
        //SleepBaby_1
        new string[] {"이제 아기를 재워볼까요?",
        "속싸개를 싸서 아기를 감싸지 않으면 아기는 깜짝놀라 자주 잠에서 깰 테니 주의해야해요.",
        "먼저 속싸개를 집어주세요."},
       //SleepBaby_2
        new string[]{ "아기에 속싸개를 떨어뜨려 속싸개를 입혀주세요"},
        //SleepBaby_3
        new string[]{ "아기에게 속싸개를 다 감싸면 아기를 안고 토닥토닥하며 재워주세요.",
        "Grip 버튼을 눌러 아기를 감싸 안아 주세요."},
        //SleepBaby_4
        new string[]{ "아기를 토닥이며 재워주세요." },
        //SleepBaby_5
        new string[]{ "아기의 눈이 게슴츠레 해지면 아기가 졸리다는 신호에요.",
        "아기의 상태를 확인해볼까요?",
        "아기가 졸려 하는 것 같으니 침대에 눕혀주세요.",
        "Grip 버튼을 떼면 침대에 눕힐 수 있어요."},
        //SleepBaby_6
        new string[]{"아기가 잠에 들었네요! 조금 휴식을 가질까요?"}
    };

    public static string[][] BabyWashSubtitle = new string[20][]
    {
        //Wash_1
        new string[] {"기저귀를 확인해볼까요?", "먼저 아기의 옷을 벗겨 주세요."},
        //Wash_2
        new string[] {"아기가 대변을 본 것 같네요.", "아기의 기저귀를 갈아볼까요?", "기저귀를 향해 Trigger 버튼을 눌러 기저귀를 풀어주세요."},
        //Wash_3
        new string[] {"기저귀에 변이 있어요. 이 때 바로 기저귀를 빼버리면 변이 흐를 수 있어요.", "아기 밑에 있는 기저귀를 빼기 위해 아기의 엉덩이를 조심스럽게 들어 주어야 해요.", "한 손으로 아기의 양쪽 발목을 조심스럽게 잡아주세요."},
        //Wash_4
        new string[] {"아기의 엉덩이를 조심스럽게 살짝 들어 올려 기저귀를 빼주세요."},
        //Wash_5
        new string[] {"준비한 물티슈를 이용해 항문 주위를 닦아주세요."},
        //Wash_7
        new string[] {"이제 화장실로 이동해서 물로 더 깨끗하게 닦아줄까요?"},
        //Wash_8
        new string[] {"아기의 엉덩이를 오른손으로 닦아줄거에요.", "왼손으로 아기의 목과 몸을 잘 받쳐주세요."},
        //Wash_9
        new string[] {"이 상태로 엉덩이를 물로 깨끗하게 씻겨주세요.", "Trigger 버튼으로 물을 틀어주세요."},
        //Wash_10
        new string[] {"흐르는 물을 움켜잡고 아기의 엉덩이에 놓아 엉덩이를 닦아주세요."},
        //Wash_12
        new string[] {"계속 반복해볼까요?"},
        //Wash_13
        new string[] {"잘하셨어요. 아기 엉덩이에 물기를 잘 제거해야 엉덩이가 짓무르지 않아요.", "손수건을 집어주세요."},
        //Wash_14
        new string[] {"손수건으로 부드럽게 엉덩이의 물기를 제거해주세요."},
        //Wash_15
        new string[] {"깨끗하게 닦았으니, 새 기저귀를 입혀주어야 해요.", "아기를 다이퍼 체인저로 데려가세요."},
        //Wash_17
        new string[] {"자 이제 새 기저귀로 갈아 입혀볼까요?", "아기의 엉덩이를 조심스럽게 살짝 들어 올려주세요.", "아기 아래에 깨끗한 기저귀를 깔아주세요."},
        //Wash_18
        new string[] {"아기의 다리를 잡던 손을 놓아 주세요."},
        //Wash_19
        new string[] {"기저귀를 향해 Trigger 버튼을 눌러 기저귀를 채우세요."},
        //Wash_20
        new string[] {"이제 아기의 옷을 입히세요."},
        //Wash_22
        new string[] {"아기를 다시 침대로 데려가 눕히세요." },
         //Wash_24
        new string[] {"아기에게 속싸개를 입혀주어야 해요." },
         //Wash_25
        new string[] {"아기에게 속싸개를 떨어뜨려 속싸개를 입혀주세요." },
    };

    public static string[][] BabyPeeSubtitle = new string[15][]
    {
        //Pee_1
        new string[] {"기저귀를 확인해볼까요?", "먼저 아기의 옷을 벗겨 주세요."},
        //Pee_2
        new string[] {"기저귀의 상태를 확인하기 위해 컨트롤러를 기저귀에 갖다 대어 보세요."},
        //Pee_3
        new string[] {"사진처럼 소변 표시줄이 바뀌면 기저귀를 갈아줘야해요.","기저귀를 갈아줘야 할 것 같아요!", "아기의 기저귀를 갈아볼까요?", "기저귀를 향해 Trigger 버튼을 눌러 기저귀를 풀어주세요."},
        //Pee_4
        new string[] {"한 손으로 아기의 양쪽 발목을 조심스럽게 잡아주세요."},
        //Pee_5
        new string[] {"아기의 엉덩이를 조심스럽게 살짝 들어 올려 기저귀를 빼주세요."},
        //Pee_6
        new string[] {"준비한 물티슈를 이용해 소변을 닦아주세요."},
        //Pee_7
        new string[] {"여아의 경우 요도에서 항문 방향으로 부드럽게 닦아주세요.", "남아의 경우에는 생식기 주변을 부드럽게 닦아주세요."},
        //Pee_8
        new string[] {"소변을 모두 닦았으면 발목을 들어올린 채로 아기의 엉덩이를 잠시 건조시켜 주세요.", "아기의 엉덩이를 깨끗하고 보송하게 유지하면 기저귀 발진을 예방할 수 있어요."},
        //Pee_9
        new string[] { "자 이제 새 기저귀로 갈아 입혀볼까요?", "아기의 엉덩이를 조심스럽게 살짝 들어 올려주세요.", "아기 아래에 깨끗한 기저귀를 깔아주세요."},
        //Pee_10
        new string[] {"아기의 다리를 잡던 손을 놓아 주세요."},
        //Pee_11
        new string[] {"기저귀를 향해 Trigger 버튼을 눌러 기저귀를 채우세요."},
        //Pee_12
        new string[] {"이제 아기의 옷을 입히세요."},
        //Pee_13
        new string[] {"아기를 다시 침대로 데려가 눕히세요."},
        //Pee_14
        new string[] {"아기를 재우기 전 속싸개를 입혀주어야 해요."},
        //Pee_15
        new string[] {"아기에게 속싸개를 떨어뜨려 속싸개를 입혀주세요."},
    };

    public static string[][] BabyNursingSubtitle = new string[14][]
    {
        //Nursing_1
        new string[] {"아기가 울고 있네요.", "아기의 입을 톡 톡 건드려 보고 입을 여는지 확인하세요."},
        //Nursing_2 입 건드린 후
        new string[] {"배가 고픈가 봐요!", "아기에게 수유를 해볼까요?", "분유를 타기 위해 주방으로 이동해주세요."},
        //Nursing_3 주방으로 이동 후
        new string[] {"분유를 알맞은 비율로 넣고 물 온도는 약 70도에서 80도로 적절하게 맞춰야 해요.", "분유 브랜드마다 적정량에 관해 표기되어 있어요.", "이제 앞에 있는 수저를 잡고 분유를 젖병에 넣어주세요." },
        //Nursing_4 분유를 넣은 후
        new string[] {"분유를 섞을 때는 기포가 생기지 않도록 과도하게 흔들지 말아야 해요.", "앞에 있는 막대를 잡고 분유를 잘 섞어주세요."},
        //Nursing_5 분유를 섞은 후
        new string[] {"분유가 잘 섞였다면 뚜껑을 닫아주세요."},
        //Nursing_6 뚜껑을 닫은 후
        new string[] {"이제 수유를 할 차례에요.", "아기 침대로 가서 아기를 안아주세요."},
        //Nursing_7 아기를 안은 후
        new string[] {"아기를 안고 소파로 이동해 주세요.", "소파 앞에 젖병이 놓여 있어요."},
        //Nursing_8 소파로 이동 후
        new string[] {"아기에게 수유를 하기 전, 손목 안쪽에 분유를 한 두 방울 떨어뜨려 온도를 확인하세요.", "또한, 아기는 분유를 주는 만큼 먹기 때문에 양 조절이 중요해요.", "과도하게 수유할 경우, 아기가 게워낼 수 있다는 점 주의하세요.", "탁자에 놓여 있는 젖병을 잡아 보세요."},
        //Nursing_9 젖병 잡은 후
        new string[] {"젖병을 아기의 입으로 가져가 수유를 진행하세요.", "아기의 머리를 누이지 않도록 주의해야 해요."},
        //Nursing_10 수유 후
        new string[] {"수유가 끝났다면 아기의 등을 쓰다듬으며 트림을 유도해주세요.", "아기의 등을 계속 쓰다듬어 보세요."},
        //Nursing_11트림 유도 1차 후
        new string[] {"아직 아기가 트림하지 않았네요.", "계속해서 아기의 등을 토닥여 주세요."},
        //Nursing_12 트림 후
        new string[] {"드디어 아기가 트림을 했어요!", "아기를 다시 침대로 데려가세요."},
        //Nursing_13
        new string[] {"아기를 재우기 전 속싸개를 입혀야 해요.","Grip 버튼을 떼어 아기를 침대에 눕히세요."},
        //Nursing_14
        new string[] {"아기가 잠에 들었네요.", "조금 휴식을 가질까요?"},
    };

    public static string[][] Transfer = new string[3][]
    {
        //Transfer_1
        new string[] {"아기를 다시 침대로 데려가 눕히세요."},
        //Transfer_2
        new string[] {"아기를 재우기 전 속싸개를 입혀주어야 해요."},
        //Transfer_4
        new string[] {"아기에게 속싸개를 떨어뜨려 속싸개를 입혀주세요."},
    };

    public static string[][] TransferToBath = new string[1][]
{
        //Transfer_1
        new string[] {"아이가 잠에서 깼나봐요!","기저귀를 확인해봐야 할 것 같아요.","기저귀를 확인하기 위해 아기를 데리고 화장실로 이동해 볼까요?"},
};
}
