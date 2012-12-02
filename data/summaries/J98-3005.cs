McKeown, 1993.
P93-1031
At least four previous systems developed elsewhere use natural language to sum475 Computational Linguistics Volume 24, Number 3 marize quantitative data, including ANA (Kukich 1983), SEMTEX (R6sner 1987), FOG (Bourbeau et al.1990), and LFS (Iordanskaja et al.1994). All of these use some forms of conceptual and linguistic summarization and the techniques can be adapted for our current work on summarization of multiple articles.
C90-3059 P83-1022
Alternatives to the use 473 Computational Linguistics Volume 24, Number 3 of frequency of key phrases included the identification and representation of lexical chains (Halliday and Hasan 1976) to find the major themes of an article followed by the extraction of one or two sentences per chain (Barzilay and Elhadad 1997), training over the position of summary sentences in the full article (Hovy and Lin 1997), and the construction of a graph of important topics to identify paragraphs that should be extracted (Mitra, Singhal, and Buckley 1997).
W97-0703 W97-0704 W97-0707
While this is a task we leave to those working in the information extraction field, we note that there do exist tools for semi-automatically acquiring such rules (Lehnert et al.1993; Fisher et al.1995). This helps to alleviate the otherwise knowledge-intensive nature of the task.
M93-1023 M95-1011
After tagging the corpus using the POS part-of-speech tagger (Church 1988), we used a CREP (Duford 1993) regular grammar to first extract all possible candidates for entities.
A88-1019
STREAK (Robin and McKeown 1993; Robin 1994; Robin and McKeown 1995) generates summaries of basketball games, using a revision-based approach to summarization.
P93-1031
This has been successful in different domains (Preston and Williams 1994) and is, in fact, the approach used in recent commercial summarizers (Apple \[Boguraev and Kennedy 1997\], Microsoft, and inXight).
W97-0702
If the summarization system can find the needed information in other on-line sources, then it can produce an improved summary by merging information extracted from the input articles with information from the other sources (Radev and McKeown 1997).
A97-1033
PLANDoc (McKeown, Kukich, and Shaw 1994a; McKeown, Robin, and Kukich 1995; Shaw 1995) generates summaries of the activities of telephone planning engineers, using linguistic summarization both to order its input messages and to combine them into single sentences.
P95-1053
ZEDDoc (Passonneau et al.1997; Kukich et al.1997) generates Web traffic summaries for advertisement management software.
W97-0903
We present a system, called SUMMONS 1 (McKeown and Radev 1995; Radev 1996; Radev and McKeown 1997), shown in Figure 1, which introduces novel techniques in the following areas: • It briefs the user on information of interest using tools related to information extraction, conceptual combination, and text generation.
A97-1033 W96-0512
of the Summarization Component The summarization component of SUMMONS is based on the traditional language generation system architecture (McKeown 1985; McDonald and Pustejovsky 1986; Hovy 1988).
P88-1020
In particular, we used FUF to implement the lexical chooser, representing the lexicon as a grammar as we have done in many previous systems (Elhadad 1993; Robin 1994; McKeown, Robin, and Tanenblatt 1993; Feiner and McKeown 1991).
P93-1031
Marcu (1997) uses a rhetorical parser to build rhetorical structure trees for arbitrary texts and produces a summary by extracting sentences that span the major rhetorical nodes of the tree.
W97-0713
We should note that extensive research in this field exists and we plan to make use of one of the proposed methods (Wacholder, Ravin, and Choi 1997) to solve this problem.
A97-1030
Techniques for proper noun extraction include the use of regular grammars to delimit and identify proper nouns (Mani et al.1993; Paik et al.1994), the use of extensive name lists, place names, titles and "gazetteers" in conjunction with partial grammars in order to recognize proper nouns as unknown words in close proximity to known words (Cowie et al.1992; Aberdeen et al.1992), statistical training to learn, for example, Spanish names, from on-line corpora (Ayuso 474 Radev and McKeown Generating Natural Language Summaries et al.1992), and the use of concept-based pattern matchers that use semantic concepts as pattern categories as well as part-of-speech information (Weischedel et al.1993; Lehnert et al.1993). In addition, some researchers have explored the use of both local context surrounding the hypothesized proper nouns (McDonald 1993; Coates-Stephens 1991) and the larger discourse context (Mani et al.1993) to improve the accuracy of proper noun extraction when large known-word lists are not available.
M92-1024 M92-1030 M92-1031 M93-1023 W93-0104 W93-0105
Focus has been on the combined use of conjunction, ellipsis, and paraphrase to result in concise, yet fluent reports (Shaw 1995).
P95-1053
Since there exist systems that can learn extraction rules for unrestricted domains (Lehnert et al.1993), the information extraction doesn't seem to present any fundamental bottleneck either.
M93-1023
We are basing our implementation on the tools developed at the University of Massachusetts (Fisher et al.1995). The resulting system will not only be able to generate summaries from preparsed templates but will also produce summaries directly from raw text by merging the message understanding component with the current version of SUMMONS.
M95-1011
