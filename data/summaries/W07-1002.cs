Proposals for computing acceptability (or preference) include raw frequency counts ((Evans and Zhai, 1996) and (Lapata and Keller, 2004)), Latent Semantic Indexing ((Buckeridge and Sutcliffe, 2002)) and statistical measures of association ((Lapata et al., 1999) and (Nakov and Hearst, 2005)).
E99-1005 P96-1003 W02-1401 W05-0603
(Lauer, 1995) argues that the dependency model is not only more intuitive than the adjacency model, but also yields better results.
P95-1007
(Nakov and Hearst, 2005) also report a similar percentage (66.8%) of left-branching noun compounds.
W05-0603
(Nakov and Hearst, 2005) use the ?2 measure based on statistics obtained from WWW search engines to compute values to determine acceptability of a syntactic analysis for nominal compounds.
W05-0603
One type of structural ambiguity that has received much attention has to do with nominal compounds as seen in the work of (Resnik, 1993), (Resnik and Hearst, 1993), (Pustejovsky et al., 1993), and (Lauer, 1995).
J93-2005 P95-1007
The reason why Banko and Moore (2004) get less than HunPos is not because their system is inherently worse, but rather because it lacks the engineering hacks built into TnT and HunPos.
W04-3243
(Lauer and Dras, 1994) and (Lauer, 1995) address the issue of structural ambiguity by developing a dependency model where instead of computing the acceptability of A[YZ] one would compute the acceptability of A[XZ].
P95-1007
One difficulty with their approach, noted by Banko and Moore (2004), is the treatment of unseen words: their method requires a full dictionary that lists what tags are possible for each word.
W04-3243
Dunning. 1993.
J93-1003
It was later applied by (Dunning, 1993) as a way to determine if a sequence of N words (Ngram) came from an independently distributed sample.
J93-1003
Moore. 2004.
W04-3243
(In fact, HunPos can handle a context window of any size, but on the limited training sets available to us increasing this parameter beyond 2 gives no further improvement.) As for contextualized lexical probabilities, our extension is very similar to Banko and Moore (2004) who use P(wi|ti??,ti,ti+1) lexical probabilities and found, on the Penn Treebank, that ?incorporating more context into an HMM when estimating lexical probabilities improved accuracy from 95.87% to 96.59%??
W04-3243
(Lauer, 1995) points out that the existing approaches to resolving the ambiguity of noun phrases fall roughly into two camps: adjacency and dependency.
P95-1007
This limitation can be partly alleviated by either only considering adjacent models and limiting the length to 5-6 words, or using a forward or backward sequential search proposed by (Pedersen et al., 1997) for the problem of selecting models for the Word Sense Disambiguation task.
A97-1056
In some recent experiments, Pedersen and Bruce (1997) have used proximity features (tags of close words and the presence or absence of close functions words 116 Schfttze Automatic Word Sense Discrimination and content words) with some promising results.
A97-1056
N2=?lifting?? For every split, we issue exact phrase queries to the Google search engine using the following patterns: "lt N1 poss N2 rt" "lt N2 prep det Nprime1 rt" "lt N2 that be det Nprime1 rt" "lt N2 that be prep det Nprime1 rt" where: lt is the word preceding N1 in the original sentence or empty if none, rt is the word following N2 in the original sentence or empty if none, poss is a possessive marker (?s or ??, that is that, which or who, be is is or are, det is a determiner (the, a, an, or none), prep is one of the 8 prepositions used by Lauer (1995) for semantic interpretation of NCs: about, at, for, from, in, of, on, and with, and Nprime1 can be either N1, or N1 with the number of its last word changed from singular/plural to plural/singular.
P95-1007
seen unseen overall TnT 96.77% 85.91% 96.46% HunPos 1 96.76% 86.90% 96.49% HunPos 2 96.88% 86.13% 96.58% Table 2: WSJ tagging accuracy, HunPos with first and second order emission/lexicon probabilities If we follow Banko and Moore (2004) and construct a full (no OOV) morphological lexicon from the tagged version of the test corpus, we obtain 96.95% precision where theirs was 96.59%.
W04-3243
It is debatable whether structural features are more informative than associational features (Grefenstette 1992, 1996) or not (Schtitze and Pedersen 1997).
A97-1056
(Moore, 2004) provided additional evidence that although G2 may not be useful for determining the significance of an event, its near equivalence to mutual information makes it an appropriate measure of word association.
W04-3243
This method is tested using a set of general English nominal compounds developed by (Lauer, 1995) as well as a set of nominal compounds extracted from MEDLINE abstracts.
P95-1007
The proponents of the adjacency model ((Liberman and Sproat, 1992), (Resnik, 1993) and (Pustejovsky et al., 1993)) argue that, given a three word noun phrase XYZ, there are two possible analyzes [[XY]Z] and [X[YZ]].
J93-2005
There are multiple approaches ranging from purely statistical (Ratnaparkhi, 1998), to hybrid approaches that take into account the lexical semantics of the verb (Hindle and Rooth, 1993), to corpus-based, which is the approach discussed in this paper.
J93-1005
Agreement between coders (and between automatic methods and coders) has been measured in the summarization literature with quite a wide range of methods: Rath, Resnick, and Savage (1961) use Kendall's ; Kupiec, Pedersen, and Chen (1995) (among many others) use percentage agreement; and Aone, Okurowski, and Gorlinsky (1997) (among others) use the notions of precision, recall, and F1 -score, which are commonly employed in the information retrieval community.
A97-1056
6. Evaluation 6.1 Introduction Traditionally, summarization systems have been evaluated in two major ways: (1) intrinsically, measuring the amount of the core information preserved from the original text (Kupiec, Pedersen, and Chen 1995; Teufel and Moens 1997), and (2) extrinsically, measuring how much the summary can benefit in accomplishing another task (e.g., finding a document relevant to a query or classifying a document into a topical category) (Mani et al.1998). In this work, we focus on intrinsic evaluation exclusively.
A97-1056
In order to ensure accuracy of the paraphrases, we use statistics gathered from the Web, using a variation of the approaches presented in Lapata and Keller (2004) and Nakov and Hearst (2005).
W05-0603
