Related Approaches Kozima (1993) describes an algorithm for the detection of text segments, which are defined as "a sequence of clauses or sentences that display local coherence" (p.
P93-1041
The results of Hearst and Plaunt (1993), 36 Hearst TextTiling Salton, Allan, and Buckley (1993) and Moffat et al.(1994) suggest that it is the nature of the intermediate size of the passages that matters.
P94-1002
Chains Morris and Hirst's pioneering work on computing discourse structure from lexical relations (Morris and Hirst 1991; Morris 1988) is a precursor to the work reported on here.
J91-1002
42 Hearst TextTiling variation in the way concepts are expressed, and so may require that thesaural relations be used as well, as in (Kozima 1993).
P93-1041
This includes author-determined segments, marked orthographically (paragraphs, sections, and chapters) (Hearst and Plaunt 1993; Salton, Allan, and Buckley 1993; Moffat et al.1994) and/or automatically derived units of text, including fixed-length blocks (Hearst and Plaunt 1993; Callan 1994), segments motivated by subtopic structure (TextTiles) (Hearst and Plaunt 1993), or segments motivated by properties of the query (Mittendorf and Sch~iuble 1994).
P94-1002
B corresponds to the number of bound13 Instead of using fixed-sized blocks, Nomoto and Nitta (1994) take advantage of the fact that Japanese provides discourse markers indicating multi-sentence units that participate in a topic/comment relationship, and find these motivated units can work slightly better.
C94-2187
6.4 Results: Quantitative Analysis To assess the results of the algorithm quantitatively, I follow the advice of Gale, Church, and Yarowsky (1992a), and compare the algorithm against both upper and lower bounds.
C92-2070 H92-1045 P92-1032
Kozima (1993) presents a very elaborate algorithm for computing the lexical cohesiveness of a window of words, using spreading activation in a semantic network created from an English dictionary.
P93-1041
Mooney, Carberry, and McCoy (1990) present a method centered around the notion of Basic Blocks: multi-paragraph units of text, each of which consists of (1) an organizational focus such as a person or a location, and (2) a set of concepts related to that focus.
C90-2048
Nomoto and Nitta (1994) implement the tf.idf version of TextTiling from Hearst (1993) and Hearst and Plaunt (1993) and evaluate it this way on Japanese newswire text.
C94-2187
Foremost among these are the attentional/intentional structure of Grosz and Sidner (1986) and the Rhetorical Structure Theory of Mann and Thompson (1987).
J86-3001
Carletta (1996) and Ros6 (1995) point out the importance of taking into account the expected chance agreement among judges when computing whether or not judges agree significantly.
J96-2004
However, in later work (Litman and Passonneau 1995), three out of seven judges marking a boundary was considered sufficient to classify, that point as a "major" boundary.
P95-1015
According to Carletta (1996), K measures pairwise agreement among a set of coders making category judgments, correcting for expected chance agreement as follows: KP(A) -P(E) 1 -P(E) where P(A) is the proportion of times that the coders agree and P(E) is the proportion of times that they would be expected to agree by chance.
J96-2004
Passonneau and Litman (1993) discuss at length considerations about evaluating segmentation algorithms according to reader judgment information.
P93-1020
Progress is being made in the automatic detection of boundaries at this level of granularity using machine learning techniques combined with a variety of well-chosen discourse cues (Litman and Passonneau 1995).
P95-1015
this one location (in the spirit of a Grosz and Sidner \[1986\] "pop" operation).
J86-3001
First, Nomoto and Nitta (1994) use too large an interval--300 words-because this is approximately the average size needed for their implementation of the blocks version of TextTiling.
C94-2187
problems in discourse analysis, such as dialogue generation and turntaking (Moore and Pollack 1992; Walker and Whittaker 1990), require fine-grained, hierarchical models that are concerned with utterance-level segmentation.
J92-4007 P90-1010
However, from the diagram it is evident that simply looking for chains of repeated terms (as suggested by Morris and Hirst \[1991\]) is not sufficient for determining subtopic breaks.
J91-1002
In Morris (1988) and Morris and Hirst (1991), tables are presented showing the sentences spanned by the lexical chains and by the corresponding segments of the attentional/intentional structure (derived by hand), but no formal evaluation is performed.
J91-1002
Since the Morris and Hirst (1991) algorithm attempts to discover attentional/intentional structure, its goals are different than those of TextTiling.
J91-1002
This work, along with that of Nomoto and Nitta (1994), on Japanese, and Hasnah (1996), on Arabic, also provides evidence that TextTiling is applicable to a wide range of natural languages.
C94-2187
One text that was used in Hearst (1994b) is not used here because inconsistencies were found in the paragraph break locations.
P94-1002
In the data of Passonneau and Litman (1993), if four or more out of seven judges mark a boundary, the segmentation is found to be significant using a variation of the Q-test (Cochran 1950).
P93-1020
This variation of the TextTiling algorithm is explored and evaluated in Hearst (1994b).
P94-1002
Overall the scores are much stronger than those reported in Reynar (1994), and are comparable to those of Nomoto and Nitta (1994) whose best precision/recall trade-off on a collection of approximately 80 articles is approximately .50 precision and .81 recall.
C94-2187 P94-1050
Proposals have recently been made for protocols for the collection of human discourse segmentation data (Nakatani et al.1995) and for how to evaluate the validity of judgments so obtained (Carletta 1996; Isard and Carletta 1995; Ros6 1995; Passonneau and Litman 1993; Litman and Passonneau 1995).
J96-2004 P93-1020 P95-1015
To compute K, each judge's decision was compared to the group decision, where a paragraph gap was considered a "true" boundary if at least three out of seven judges placed a boundary mark there, as in Litman and Passonneau (1995).
P95-1015
Three methods for score assignment have been explored: blocks, vocabulary introductions, and chains, although only the first two are evaluated in this article (the third is discussed in Hearst \[1994b\]).
P94-1002
The work described here makes use only of lexical distribution information, in lieu of prosodic cues such as intonational pitch, pause, and duration (Hirschberg and Nakatani 1996), discourse markers such as oh, well, ok, however (Schiffrin 1987; Litman and Passonneau 1995), pronoun reference resolution (Passonneau and Litman 1993; Webber 1988) and tense and aspect (Webber 1987; Hwang and Schubert 1992).
P87-1021 P88-1014 P92-1030 P93-1020 P95-1015 P96-1038
Nomoto and Nitta (1994) attempt to use Youmans' algorithm for distinguishing entire articles from one another when they are concatenated into a single file.
C94-2187
This approach differs from that of Youmans (1991) and Nomoto and Nitta (1994) in two main ways.
C94-2187
Carletta (1996) also states that in the behavioral sciences, K > .8 signals good replicability, and .67 < K < .8 allows tentative conclusions to be drawn.
J96-2004
13 Also, as discussed in Section 4, Reynar (1994) uses this form of evaluation on a greedy version of the blocks algorithm.
P94-1050
Recently, Hirschberg 52 Hearst TextTiling and Nakatani (1996) have reported promising results for obtaining higher interjudge agreement using their collection protocols.
P96-1038
Reynar (1994) describes an algorithm similar to that of Hearst (1993) and Hearst and Plaunt (1993) with a difference in the way in which the size of the blocks of adjacent regions are chosen.
P94-1050
The approach to similarity comparison suggested by Kozima (1993), while very expensive to compute, might also prove able to improve results.
P93-1041
Judgments There is a growing concern surrounding issues of intercoder reliability when using human judgments to evaluate discourse-processing algorithms (Carletta 1996; Condon and Cech 1995).
J96-2004
A thesaurus-based disambiguation algorithm (Yarowsky 1992) may help alleviate this problem (this option is revisited in Section 7), but another solution is to move away from thesaurus classes and use simple word co-occurrence instead, since within a given text a word is usually used with only one sense (Gale, Church, and Yarowsky 1992b).
C92-2070 H92-1045 P92-1032
The use of discourse cues for detection of segment boundaries and other discourse purposes has been extensively researched, although predominantly on spoken text (see Hirschberg and Litman \[1993\] for a summary of six research groups' treatments of 64 cue words).
J93-3003
Many researchers, (e.g., Halliday and Hasan \[1976\], Tarmen \[1989\], and Walker \[1992\]), have noted that term repetition is a strong cohesion indicator.
C92-1054
The chains are used to structure texts according to the attentional/intentional theory of discourse structure (Grosz and Sidner 1986) discussed above.
J86-3001
Because the goal is to partition texts into contiguous, nonoverlapping subtopic segments, I call the general approach TextTiling (Hearst, 1993, 1994a, 1994b).
P94-1002
