using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveMove.Rules
{
    class Covering
    {
        public static string rule;
        static public string get(string 감독, string 계절, string 제작사, string 장르, string 관람등급, string 배급사)
        {
            string res = "";
            rule = "";
            if (배급사 == "(주)조이앤컨텐츠그룹")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)조이앤컨텐츠그룹\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)케이알씨지")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)케이알씨지\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)소나무픽쳐스")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)소나무픽쳐스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (장르 == "성인물(에로)")
            {
                res += "0 ~ 3547\n";
                rule += "If 장르 is 성인물(에로)\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)노이에스")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)노이에스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "민두식")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 민두식\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)피터팬픽쳐스")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)피터팬픽쳐스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "한국영화아카데미")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 한국영화아카데미\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)미디어캐슬")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)미디어캐슬\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "타케키요 히토시")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 타케키요 히토시\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)컴퍼니엘")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)컴퍼니엘\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)미디어로그")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)미디어로그\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "피디픽쳐스")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 피디픽쳐스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)노마드필름")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)노마드필름\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "(주)키노아이디엠씨")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)키노아이디엠씨\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "(주)스넵쏘울")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)스넵쏘울\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "(주)루믹스미디어")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)루믹스미디어\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "무라타 카즈야")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 무라타 카즈야\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "요시노 히로시")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 요시노 히로시\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "오영두")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 오영두\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "자비에 장")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 자비에 장\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "박루슬란")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 박루슬란\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "빅터 플레밍")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 빅터 플레밍\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "오토모 가츠히로")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 오토모 가츠히로\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "오카무라 텐사이")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 오카무라 텐사이\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "모리모토 코지")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 모리모토 코지\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "어일선")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 어일선\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "김건")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 김건\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "포디렉터스")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 포디렉터스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)나우콘텐츠")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)나우콘텐츠\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "서울독립영화제")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 서울독립영화제\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "(주)토러스엔터테인먼트")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)토러스엔터테인먼트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (장르 == "기타")
            {
                res += "0 ~ 3547\n";
                rule += "If 장르 is 기타\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "S. 샹카르")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is S. 샹카르\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "안나 저스티스")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 안나 저스티스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이상우")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이상우\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "다니엘 알프레드슨")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 다니엘 알프레드슨\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "호리키리조노 켄타로")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 호리키리조노 켄타로\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "우다 고노스케")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 우다 고노스케\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "제임스 보빈")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 제임스 보빈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "구스타보 헤르난데즈")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 구스타보 헤르난데즈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "헬렌 헌트")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 헬렌 헌트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "레니 할린")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 레니 할린\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "미미 레더")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 미미 레더\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)인벤트스톤")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)인벤트스톤\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "라인트리엔터테인먼트")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 라인트리엔터테인먼트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)맑음영화사")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)맑음영화사\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)에이브이에이엔터테인먼트")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)에이브이에이엔터테인먼트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "(주)에스와이코마드")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)에스와이코마드\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "(주)시네마달")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)시네마달\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "어뮤즈")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is 어뮤즈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "㈜크래커픽쳐스")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is ㈜크래커픽쳐스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (배급사 == "미디어소프트")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is 미디어소프트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이광국")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이광국\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "잉마르 베리만")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 잉마르 베리만\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "김경묵")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 김경묵\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "존 건")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 존 건\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "지민")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 지민\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "백승화")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 백승화\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "발레리 게르기예프")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 발레리 게르기예프\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "오키타 슈이치")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 오키타 슈이치\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "백연아")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 백연아\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "임진순")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 임진순\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이수성")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이수성\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "데틀레프 북")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 데틀레프 북\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "크리스티안 E.크리스티안센")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 크리스티안 E.크리스티안센\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "허철")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 허철\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "공귀현")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 공귀현\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이마카케 이사무")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이마카케 이사무\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "지하진")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 지하진\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "도미니크 아벨")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 도미니크 아벨\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "피오나 고든")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 피오나 고든\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "브루노 로미")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 브루노 로미\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "전수일")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 전수일\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "안토니오 니그렛")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 안토니오 니그렛\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "버나드 로즈")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 버나드 로즈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "로베르트 르빠쥬")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 로베르트 르빠쥬\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "송예섭")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 송예섭\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이네 살림")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이네 살림\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "김기현")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 김기현\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "박성수")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 박성수\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "백상열")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 백상열\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "크리스 무어")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 크리스 무어\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)프리비젼엔터테인먼트")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)프리비젼엔터테인먼트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "애즈필름")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 애즈필름\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)케빈앤컴퍼니")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is (주)케빈앤컴퍼니\n Then: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "도키엔터테인먼트")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 도키엔터테인먼트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "박흥식")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 박흥식\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "수유 린")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 수유 린\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "리차드 켈리")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 리차드 켈리\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "아이라 잭스")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 아이라 잭스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "크리스 웨이츠")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 크리스 웨이츠\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "닐스 아르덴 오플레브")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 닐스 아르덴 오플레브\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "알랭 레네")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 알랭 레네\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "데이빗 홀랜더")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 데이빗 홀랜더\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "벨라 타르")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 벨라 타르\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "유형")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 유형\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "다카하시 반메이")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 다카하시 반메이\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "히시다 마사카즈")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 히시다 마사카즈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "사사가와 히로시")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 사사가와 히로시\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "아미르 나데리")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 아미르 나데리\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "야마시타 노부히로")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 야마시타 노부히로\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "루카 미니에로")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 루카 미니에로\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "게레온 베첼")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 게레온 베첼\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "신수원")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 신수원\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이수연")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이수연\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "김성호")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 김성호\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "파울 슈마츠니")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 파울 슈마츠니\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "리 위")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 리 위\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "데이빗 겔브")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 데이빗 겔브\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "서극")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 서극\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "한지원")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 한지원\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "크리스티안 히메네즈")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 크리스티안 히메네즈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "베네덱 플리고프")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 베네덱 플리고프\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "유호진")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 유호진\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "베노이트 필립폰")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 베노이트 필립폰\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "마티유 아말릭")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 마티유 아말릭\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "송일곤")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 송일곤\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "마이클 그랑디지")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 마이클 그랑디지\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "히가시 요이치")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 히가시 요이치\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "데이빗 맥킨지")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 데이빗 맥킨지\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이상빈")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이상빈\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "프레데릭 와이즈만")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 프레데릭 와이즈만\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이정황")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이정황\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "강효진")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 강효진\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "저스틴 채드윅")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 저스틴 채드윅\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "야니케 시스타드 야콥슨")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 야니케 시스타드 야콥슨\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "린 유시엔")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 린 유시엔\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이수정")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이수정\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "수오 마사유키")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 수오 마사유키\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "카트린느 브레이야")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 카트린느 브레이야\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "제임스 마쉬")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 제임스 마쉬\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "로랑 펠리")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 로랑 펠리\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "데이비드 멕비카")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 데이비드 멕비카\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "에릭 바레트")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 에릭 바레트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "최용석")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 최용석\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "스테판 리보자드")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 스테판 리보자드\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "박영철")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 박영철\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "팰림 맥더모트")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 팰림 맥더모트\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "호베흐또 가흐제이휴")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 호베흐또 가흐제이휴\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "브래드 T. 갓프레드")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 브래드 T. 갓프레드\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "전화성")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 전화성\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "하스미 에이이치로")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 하스미 에이이치로\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "인진미")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 인진미\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "카를로스 레이가다스")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 카를로스 레이가다스\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "월리엄 크리스티")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 월리엄 크리스티\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "박준범")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 박준범\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "이세야 유스케")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 이세야 유스케\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "피터 도드")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 피터 도드\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "고명안")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 고명안\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "위트 스틸먼")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 위트 스틸먼\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "임초현")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 임초현\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "코바야시 츠네오")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 코바야시 츠네오\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "타라 퍼니아")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 타라 퍼니아\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "뎁 헤이갠")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 뎁 헤이갠\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "앙토니 코르디에")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 앙토니 코르디에\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "필국지")
            {
                res += "0 ~ 3547\n";
                rule += "If 감독 is 필국지\n Then: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "변성현"
            && 제작사 == "(주)다세포클럽")
            {
                res += "0 ~ 3547\n";
                rule += "If 제작사 is 변성현 "; rule += "and 제작사 == (주)다세포클럽\nThen: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)스폰지이엔티"
            && 배급사 == "(주)영화사 조제")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is (주)스폰지이엔티 "; rule += "and 배급사 == (주)영화사 조제\nThen: "; rule += "0 ~ 3547\n";
            }
            if (감독 == "홍지영"
            && 배급사 == "골든타이드픽처스(주)")
            {
                res += "0 ~ 3547\n";
                rule += "If 배급사 is 홍지영 "; rule += "and 배급사 == 골든타이드픽처스(주)\nThen: "; rule += "0 ~ 3547\n";
            }
            if (제작사 == "(주)에스비에스콘텐츠허브")
            {
                res += "3547 ~ 64195\n";
                rule += "If 제작사 is (주)에스비에스콘텐츠허브\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "피터 레페니오티스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 피터 레페니오티스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (제작사 == "(주)티캐스트")
            {
                res += "3547 ~ 64195\n";
                rule += "If 제작사 is (주)티캐스트\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "데이비드 에이어")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 데이비드 에이어\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "아리엘 슐만")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 아리엘 슐만\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "헨리 유스트")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 헨리 유스트\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "김조광수")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 김조광수\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "손석")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 손석\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "스티븐 소더버그")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 스티븐 소더버그\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "매티스 반 헤이닌겐 주니어")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 매티스 반 헤이닌겐 주니어\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "제임스 완")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 제임스 완\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "로저 도날드슨")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 로저 도날드슨\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "이나 예블라니코바")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 이나 예블라니코바\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "스비야토슬라브 우샤코프")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 스비야토슬라브 우샤코프\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "아몰 굽트")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 아몰 굽트\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "제시 페레츠")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 제시 페레츠\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "마크 포스터")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 마크 포스터\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "줄리 앤 로빈슨")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 줄리 앤 로빈슨\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "조병옥")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 조병옥\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "가렛 에반스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 가렛 에반스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "라스 폰 트리에")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 라스 폰 트리에\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "사토 히로유키")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 사토 히로유키\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "주현량")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 주현량\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "후지모리 마사야")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 후지모리 마사야\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "베스 카그맨")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 베스 카그맨\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (제작사 == "소니픽쳐스릴리징월트디즈니스튜디오스코리아(주)")
            {
                res += "3547 ~ 64195\n";
                rule += "If 제작사 is 소니픽쳐스릴리징월트디즈니스튜디오스코리아(주)\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (제작사 == "CGV 무비꼴라쥬")
            {
                res += "3547 ~ 64195\n";
                rule += "If 제작사 is CGV 무비꼴라쥬\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "존 힐코트")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 존 힐코트\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "나가이시 다카오")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 나가이시 다카오\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "스콧 데릭슨")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 스콧 데릭슨\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "존 매든")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 존 매든\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "알렉산더 페인")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 알렉산더 페인\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "발타자르 코루마쿠르")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 발타자르 코루마쿠르\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "켄 콰피스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 켄 콰피스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "로드리고 코르테스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 로드리고 코르테스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "피트 트래비스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 피트 트래비스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "파스칼 쇼메유")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 파스칼 쇼메유\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "맥스 기와")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 맥스 기와\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "다니아 파스퀴니")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 다니아 파스퀴니\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "더 비셔우스 브라더스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 더 비셔우스 브라더스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "정재은")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 정재은\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "구파도")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 구파도\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "구혜선")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 구혜선\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "마커스 니스펠")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 마커스 니스펠\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "최진성")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 최진성\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "다비드 포앙키노스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 다비드 포앙키노스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "스테판 포엔키노스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 스테판 포엔키노스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "홍상수")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 홍상수\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "데클란 도넬란")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 데클란 도넬란\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "닉 오머로드")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 닉 오머로드\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "데이빗 크로넨버그")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 데이빗 크로넨버그\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "김문흠")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 김문흠\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "로만 폴란스키")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 로만 폴란스키\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "신동엽")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 신동엽\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "윌리엄 모나한")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 윌리엄 모나한\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "존 허위츠")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 존 허위츠\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "헤이든 쉬로스버그")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 헤이든 쉬로스버그\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "데렉 시앤프랭스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 데렉 시앤프랭스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "페르난도 트루에바")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 페르난도 트루에바\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "하비에르 마리스칼")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 하비에르 마리스칼\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "토노 에란도")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 토노 에란도\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "마크 톤데라이")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 마크 톤데라이\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "이대희")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 이대희\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "카를로 미라벨라 데이비스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 카를로 미라벨라 데이비스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "크리스 답킨스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 크리스 답킨스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "닉 어거스트 페르나")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 닉 어거스트 페르나\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "브루스 로빈슨")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 브루스 로빈슨\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "강이관")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 강이관\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "미셸 오슬로")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 미셸 오슬로\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "톰 맥카시")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 톰 맥카시\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "리처드 J. 루이스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 리처드 J. 루이스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "오기가미 나오코")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 오기가미 나오코\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "마미 스나다")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 마미 스나다\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "진재운")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 진재운\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "미타니 코키")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 미타니 코키\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "무라타 마사히코")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 무라타 마사히코\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "사부")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 사부\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "김성훈")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 김성훈\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (제작사 == "㈜MBC")
            {
                res += "3547 ~ 64195\n";
                rule += "If 제작사 is ㈜MBC\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "마틴 스콜세지")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 마틴 스콜세지\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "곽경택")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 곽경택\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "타케우치 요시오")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 타케우치 요시오\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "조지 클루니")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 조지 클루니\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "로버트 로렌즈")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 로버트 로렌즈\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "타니구치 고로")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 타니구치 고로\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "백창주")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 백창주\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "안드리아 아놀드")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 안드리아 아놀드\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "김태균")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 김태균\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "아미르 칸")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 아미르 칸\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "빔 벤더스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 빔 벤더스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "말릭 벤젠룰")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 말릭 벤젠룰\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "마이클 화이트")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 마이클 화이트\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "올리버 스톤")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 올리버 스톤\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "사이먼 커티스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 사이먼 커티스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "이승준")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 이승준\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "천정훈")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 천정훈\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "자비에 보브와")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 자비에 보브와\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "민병훈")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 민병훈\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "조정래")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 조정래\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "비자이")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 비자이\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "김재환")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 김재환\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "뤽 베송")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 뤽 베송\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "우슬라 마이어")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 우슬라 마이어\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "클라우스 해로")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 클라우스 해로\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "미시마 유키코")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 미시마 유키코\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "겔라 바블루아니")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 겔라 바블루아니\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "스기노 아키오")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 스기노 아키오\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "후미히로 요시무라")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 후미히로 요시무라\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "허안화")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 허안화\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "닉 스트링거")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 닉 스트링거\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "패디 콘시딘")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 패디 콘시딘\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "이인항")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 이인항\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "티모 부오렌솔라")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 티모 부오렌솔라\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "매튜 본")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 매튜 본\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "브렛 설리반")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 브렛 설리반\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "사이몬 필립스")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 사이몬 필립스\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "페오 알라다그")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 페오 알라다그\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "사나다 아츠시")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 사나다 아츠시\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "진광교")
            {
                res += "3547 ~ 64195\n";
                rule += "If 감독 is 진광교\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (제작사 == "주식회사 풍경소리")
            {
                res += "3547 ~ 64195\n";
                rule += "If 제작사 is 주식회사 풍경소리\n Then: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "조성규"
            && 배급사 == "(주)마인스 엔터테인먼트")
            {
                res += "3547 ~ 64195\n";
                rule += "If 배급사 is 조성규 "; rule += "and 배급사 == (주)마인스 엔터테인먼트\nThen: "; rule += "3547 ~ 64195\n";
            }
            if (감독 == "이근우")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 이근우\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "제임스 왓킨스")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 제임스 왓킨스\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (제작사 == "(주)부메랑모션픽쳐스")
            {
                res += "64195 ~ 188648\n";
                rule += "If 제작사 is (주)부메랑모션픽쳐스\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (제작사 == "지오엔터테인먼트")
            {
                res += "64195 ~ 188648\n";
                rule += "If 제작사 is 지오엔터테인먼트\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "조지 밀러")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 조지 밀러\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "닐 버거")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 닐 버거\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "미셸 아자나비슈스")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 미셸 아자나비슈스\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "마크 네브다인")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 마크 네브다인\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "브라이언 테일러")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 브라이언 테일러\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "김익로")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 김익로\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "후안 디에고 솔라나스")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 후안 디에고 솔라나스\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "론 쉐르픽")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 론 쉐르픽\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "쿠스바 고조")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 쿠스바 고조\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "다니엘 에스피노사")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 다니엘 에스피노사\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "크리스 고락")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 크리스 고락\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "스티븐 스필버그")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 스티븐 스필버그\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "제임스 맥티그")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 제임스 맥티그\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "필리다 로이드")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 필리다 로이드\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "벤 애플렉")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 벤 애플렉\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "타케모토 노보루")
            {
                res += "64195 ~ 188648\n";
                rule += "If 감독 is 타케모토 노보루\n Then: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "하나부사 츠토무"
            && 제작사 == "오퍼스픽쳐스(유)")
            {
                res += "64195 ~ 188648\n";
                rule += "If 제작사 is 하나부사 츠토무 "; rule += "and 제작사 == 오퍼스픽쳐스(유)\nThen: "; rule += "64195 ~ 188648\n";
            }
            if (감독 == "호소다 마모루")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 호소다 마모루\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "허진호")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 허진호\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "조 카나한")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 조 카나한\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "장윤현")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 장윤현\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "김진영")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 김진영\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "정범식")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 정범식\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "임대웅")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 임대웅\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "김선")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 김선\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "라인하드 클루스")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 라인하드 클루스\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "호거 태프")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 호거 태프\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "오키우라 히로유키")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 오키우라 히로유키\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "정용주")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 정용주\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "카메론 크로우")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 카메론 크로우\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "세스 맥파라인")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 세스 맥파라인\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "유야마 쿠니히코")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 유야마 쿠니히코\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "크리스 리노드")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 크리스 리노드\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "카일 발다")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 카일 발다\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "마스이 소이치")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 마스이 소이치\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "캐리 주스넌")
            {
                res += "188648 ~ 339294\n";
                rule += "If 감독 is 캐리 주스넌\n Then: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "정지영"
            && 계절 == "가을")
            {
                res += "188648 ~ 339294\n";
                rule += "If 계절 is 정지영 "; rule += "and 계절 == 가을\nThen: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "홍지영"
            && 배급사 == "롯데쇼핑㈜롯데엔터테인먼트")
            {
                res += "188648 ~ 339294\n";
                rule += "If 배급사 is 홍지영 "; rule += "and 배급사 == 롯데쇼핑㈜롯데엔터테인먼트\nThen: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "민규동"
            && 배급사 == "롯데쇼핑㈜롯데엔터테인먼트")
            {
                res += "188648 ~ 339294\n";
                rule += "If 배급사 is 민규동 "; rule += "and 배급사 == 롯데쇼핑㈜롯데엔터테인먼트\nThen: "; rule += "188648 ~ 339294\n";
            }
            if (감독 == "게리 로스")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 게리 로스\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "김달중")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 김달중\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "폴 W.S. 앤더슨")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 폴 W.S. 앤더슨\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "박철관")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 박철관\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "제임스 매더스")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 제임스 매더스\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "스테판 S")
            {
                res += "물毒?then 339294 ~ 615783\n";
                rule += "If 감독 is 스테판 S\n Then: "; rule += "물毒?then 339294 ~ 615783\n";
            }
            if (감독 == "김동빈")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 김동빈\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "애스게르 레스")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 애스게르 레스\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "타셈 싱")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 타셈 싱\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "라이언 존슨")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 라이언 존슨\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "한지승")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 한지승\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "사이먼 웨스트")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 사이먼 웨스트\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "데이빗 핀처")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 데이빗 핀처\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "김기덕")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 김기덕\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "시즈노 코분")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 시즈노 코분\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "야마모토 야스이치로")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 야마모토 야스이치로\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "정승구")
            {
                res += "339294 ~ 615783\n";
                rule += "If 감독 is 정승구\n Then: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "팀 버튼"
            && 제작사 == "워너브러더스코리아(주)")
            {
                res += "339294 ~ 615783\n";
                rule += "If 제작사 is 팀 버튼 "; rule += "and 제작사 == 워너브러더스코리아(주)\nThen: "; rule += "339294 ~ 615783\n";
            }
            if (감독 == "한상호")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 한상호\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "피터 램지")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 피터 램지\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "권칠인")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 권칠인\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "신정원")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 신정원\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "맥지")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 맥지\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "토니 길로이")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 토니 길로이\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "우선호")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 우선호\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "김용한")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 김용한\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "리들리 스콧")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 리들리 스콧\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "조나단 리브스만")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 조나단 리브스만\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "김태경")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 김태경\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "앤드류 스탠든")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 앤드류 스탠든\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "정용기")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 정용기\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "스콧 스피어")
            {
                res += "615783 ~ 1108072\n";
                rule += "If 감독 is 스콧 스피어\n Then: "; rule += "615783 ~ 1108072\n";
            }
            if (감독 == "전계수")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 전계수\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "스티브 마티노")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 스티브 마티노\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "마이크 트메이어")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 마이크 트메이어\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "김홍선")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 김홍선\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "김형준")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 김형준\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (제작사 == "블루미지")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 제작사 is 블루미지\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "문현성")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 문현성\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "에릭 다넬")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 에릭 다넬\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "톰 맥그라스")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 톰 맥그라스\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "콘래드 베논")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 콘래드 베논\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "우민호")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 우민호\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "유하")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 유하\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "방은진")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 방은진\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "벤 스타센")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 벤 스타센\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "신태라")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 신태라\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "정지우")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 정지우\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (제작사 == "나의PS파트너 문화산업전문회사")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 제작사 is 나의PS파트너 문화산업전문회사\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "정기훈")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 정기훈\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "마크 앤드류스")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 마크 앤드류스\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "브렌다 채프먼")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 브렌다 채프먼\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "렌 와이즈먼")
            {
                res += "1108072 ~ 1888876\n";
                rule += "If 감독 is 렌 와이즈먼\n Then: "; rule += "1108072 ~ 1888876\n";
            }
            if (감독 == "조근현")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 조근현\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "정병길")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 정병길\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "빌 콘돈")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 빌 콘돈\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "김대승")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 김대승\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "피터 잭슨")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 피터 잭슨\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "톰 후퍼")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 톰 후퍼\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "변영주")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 변영주\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "김휘")
            {
                res += "1888876 ~ 3240545\n";
                rule += "If 감독 is 김휘\n Then: "; rule += "1888876 ~ 3240545\n";
            }
            if (감독 == "김주호")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 김주호\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "윤종빈")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 윤종빈\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "이석훈")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 이석훈\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "박정우")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 박정우\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "이용주")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 이용주\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (제작사 == "영화사 집")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 제작사 is 영화사 집\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "마크 웹")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 마크 웹\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "베리 소넨필드")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 감독 is 베리 소넨필드\n Then: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "민규동"
            && 배급사 == "(주)넥스트엔터테인먼트월드(NEW)")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 배급사 is 민규동 "; rule += "and 배급사 == (주)넥스트엔터테인먼트월드(NEW)\nThen: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "정지영"
            && 배급사 == "(주)넥스트엔터테인먼트월드(NEW)")
            {
                res += "3240545 ~ 5644069\n";
                rule += "If 배급사 is 정지영 "; rule += "and 배급사 == (주)넥스트엔터테인먼트월드(NEW)\nThen: "; rule += "3240545 ~ 5644069\n";
            }
            if (감독 == "조성희")
            {
                res += "5644069 ~ 11376139\n";
                rule += "If 감독 is 조성희\n Then: "; rule += "5644069 ~ 11376139\n";
            }
            if (감독 == "크리스토퍼 놀란")
            {
                res += "5644069 ~ 11376139\n";
                rule += "If 감독 is 크리스토퍼 놀란\n Then: "; rule += "5644069 ~ 11376139\n";
            }
            if (감독 == "조스 웨던")
            {
                res += "5644069 ~ 11376139\n";
                rule += "If 감독 is 조스 웨던\n Then: "; rule += "5644069 ~ 11376139\n";
            }
            if (감독 == "추창민")
            {
                res += "11376139 ~\n";
                rule += "If 감독 is 추창민\n Then: "; rule += "11376139 ~\n";
            }
            if (감독 == "최동훈")
            {
                res += "11376139 ~\n";
                rule += "If 감독 is 최동훈\n Then: "; rule += "11376139 ~\n";
            }

            return res;
        }
    }
}
