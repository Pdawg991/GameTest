using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveNovel
{
    public class Data
    {
        public static string chapterOne = """
    It was a cold morning—cold outside and even colder inside. Her very spirit felt chilled as
she lay awake, staring at the roof of her tent, contemplating all that happened yesterday.
    Viron was gone. He had left last night. Their leader had set out to complete the mission
on his own.
    He said he had to.
    He said it was his fault they had failed.
    He said that he had to make things right.
    Now she was in charge. The little band of Vari were now under her leadership. Viron had
asked her to continue on her quest, the reason she had left home in the first place. An ancient
prophecy among the Healers of the East, the Ori’sid, spoke of a young girl who would retrieve
the Sword of Pervenerat. This ancient relic had in times past been stolen from her people by the
minions of the evil Lord of Darkness. Its magic being a mighty threat to his power, the Dark
Lord had locked the weapon away in a vault high up in the Mountains of the Northern Wastes,
never to be seen again for a thousand years. The night on which she had been born marked
precisely one millennium since the Sword had been taken, and the Grand Council had solemnly
declared her the one who would retrieve it. Though the fell villain-god had since been defeated
by the Blessed Ones, called Orim in the old tongue, the Council felt that this was the proper time
to recover the weapon. She had been trained her entire life for this one mission, and she was
more than ready.
    At least, that was what she kept telling herself as she lay there. She knew that nothing
would stand in the way of her determined young friends. It was herself she doubted. Her first
quest had seemed immensely important upon its inception, but now, compared with the
monumental and world shattering doom that Viron had set out alone to vanquish, her mission
had all but faded into the realm of forgotten memories and long lost dreams. But this was what
she had been born for. This was her purpose in life.
    Or was it? Wasn’t there more that she could do, more that she had to do? To help Viron,
yes, but also to help her own people? Sure, the Sword was powerful, and belonged among the
Ori’sid. But Sword or no Sword, the world would end if Viron could not stop the Smiths in time.
What if he needed help? Should she go after him, or fulfill her destiny and continue on her
quest? What should she do?
""";

        public static string chapterTwo = """
    “Rema… Rema, are you there?” The voice of Nemrion was an unneeded reminder of the
immediate necessity and import of her decision.
    “Y-yeah, I’m here. Come in.”
    The young Vari entered her tent. She could see the sorrow of Viron’s departure etched
into his features, though he did his best to hide it.
    “Ummm, the guys and I were wondering if you had any, you know, orders. You’re our
leader now. What’s next?”
    If only I knew, she sighed. Attempting to seem calm and prepared, she cooly replied,
“Gather them outside my tent. I’ll be out shortly.”
    “Right away.” Nemrion turned around to go, but Rema motioned for him to stay.
    “Tell them that it is all under control. Viron knew what he was doing.” Putting her hand
on his shoulder, she continued, “I’m sure it was especially hard leaving you.”
    He gave a half-hearted smile, and left.

Standing out front of the tent facing her new team, Rema cleared her throat and began. "I
know that Viron’s departure has been hard for us all. He was… he is our leader on this incredible
journey. But right now, as temporary leader, I have decided that we… {0}"
    “We will follow you to the gates of Ingloregna, Rema,” spoke up Felixius, long since
cured of his timidity.
    “Ay ay!” they all chanted in response.
    “Then let us begin. Onward, to find what was lost, to recover what shall be found.”
    With that the band set out, their first obstacle being already before their eyes: the Great
Northern Mountain. This gargantuan peak stretched its summit well above the clouds. No
navigable pass across the range existed for miles in either direction. If they were going to get
across before winter set in, it would have to be across that formidable
""";

		public string[][] allDecisions = new string[2][]{
				new string[5]{"Surprise me!", "Pursue Viron", "Continue on the quest for the Sword of Pervenerat", "", "" },
				new string[4]{ "this", "that", "the", "another"}
			};
		public string[] ch2Options = { "Surprise me!", "Pursue Viron", "Continue on the quest for the Sword of Pervenerat", "", "" };
        public string[] ch3Options = { "this", "that", "the", "another" };
        public string[] ch4Options = { "this", "that", "the", "another" };
        public string[] allChapters = new string[] { chapterOne, chapterTwo };
	}
}
