Finally, word similarity can be computed from structural features like head-modifier relationships (Grefenstette 1994b; Ruge 1992; Dagan, Marcus, and Markovitch 1993; Pereira, Tishby, and Lee 1993; Dagan, Pereira, and Lee 1994).
P93-1022 P93-1024 P94-1038
Kelly and Stone (1975) consider hand-constructed disambiguation rules; Lesk (1986), Krovetz and Croft (1989), Guthrie et al.(1991), and Karov and Edelman (1996) use on-line dictionaries; Hirst (1987) constructs knowledge bases; Cottrell (1989) uses syntactic and semantic structure encoded in a connectionist net; Brown et al.(1991) and Church and Gale (1991) exploit bilingual corpora; Dagan, Itai, and Schwall (1991) use a bilingual dictionary; Hearst (1991), Leacock, Towell, and Voorhees (1993), Niwa and Nitta (1994), and Bruce and Wiebe (1994) exploit a hand-labeled training set; and Yarowsky (1992) and Walker and Amsler (1986) perform computations based on a hand-constructed semantic categorization of words (Roget's Thesaurus and Longman's subject codes, respectively).
C92-2070 C94-1049 H93-1051 P91-1017 P91-1019 P91-1034 P94-1020 W93-0102 W96-0104
It is possible to integrate information in the context vectors that reflect syntactic or subcategorization behavior of different senses, such as the output of a shallow parser as used in Pereira, Tishby, and Lee (1993).
P93-1024
A number of alignment techniques have been proposed, varying from statistical methods (Brown et al., 1991; Gale and Church, 1991) to lexical methods (Kay and RSscheisen, 1993; Chen, 1993).
P91-1034
Approaches to word representation closely related to ours were proposed by Niwa and Nitta (1994) and Burgess and Lund (1997).
C94-1049
Appendix A: Singular Value Decomposition A singular value decomposition factors an m-by-n matrix A into a product of three matrices: (,)A = U diag (o1,...,o.p)V T 4 See Leacock (1993) for a discussion of proximity and topical features in supervised disambiguation.
H93-1051 W93-0102
Other algorithms for computing context vectors have been proposed by Wilks et al.(1990) (based on dictionary entries), Gallant (1991) (based on hand-encoded semantic features), Grefenstette (1994b) (based on light parsing), and Niwa and Nitta (1994) (a comparison of dictionary-based and corpus-based context vectors).
C94-1049
Agreement between coders (and between automatic methods and coders) has been measured in the summarization literature with quite a wide range of methods: Rath, Resnick, and Savage (1961) use Kendall's ; Kupiec, Pedersen, and Chen (1995) (among many others) use percentage agreement; and Aone, Okurowski, and Gorlinsky (1997) (among others) use the notions of precision, recall, and F1 -score, which are commonly employed in the information retrieval community.
W97-0322
(See Karov and Edelman \[1996\] for a different approach that selects features according to a combination of global frequency and local salience).
W96-0104
In some recent experiments, Pedersen and Bruce (1997) have used proximity features (tags of close words and the presence or absence of close functions words 116 Schfttze Automatic Word Sense Discrimination and content words) with some promising results.
W97-0322
It is debatable whether structural features are more informative than associational features (Grefenstette 1992, 1996) or not (Schtitze and Pedersen 1997).
W97-0322
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J92-4003 P93-1024
The average performance of the SVD-based representations of 83% to 91% is satisfactory, although inferior by about 5% to 10%, to disambiguation with minimal manual intervention (e.g., Yarowsky \[1995\]).
P95-1026
Word Training Test Rare Senses Baseline Frequent Senses ruling 5,482 200 3.5% 60% an authoritative decision to exert control, or influence space 9,136 200 0% 56% area, volume outer space suit/s 7,467 200 12.5% 57% an action or process in a court a set of garments tank/s 3,909 200 4.5% 90% a combat vehicle a receptacle for liquids train/s 4,271 200 1.5% 74% a line of railroad cars to teach vessel/s 1,618 144 13.9% 69% a ship or plane a tube or canal (as an artery) Artificial ambiguous words or pseudowords are a convenient means of testing disambiguation algorithms (Schtitze 1992a; Gale, Church, and Yarowsky 1992).
C92-2070
6. Evaluation 6.1 Introduction Traditionally, summarization systems have been evaluated in two major ways: (1) intrinsically, measuring the amount of the core information preserved from the original text (Kupiec, Pedersen, and Chen 1995; Teufel and Moens 1997), and (2) extrinsically, measuring how much the summary can benefit in accomplishing another task (e.g., finding a document relevant to a query or classifying a document into a topical category) (Mani et al.1998). In this work, we focus on intrinsic evaluation exclusively.
W97-0322
Regardless of whether it takes the form of dictionaries (Lesk 1986; Guthrie et al.1991; Dagan, Itai, and Schwall 1991; Karov and Edelman 1996), thesauri (Yarowsky 1992; Walker and Amsler 1986), bilingual corpora (Brown et al.1991; Church and Gale 1991), or hand-labeled training sets (Hearst 1991; Leacock, Towell, and Voorhees 1993; Niwa and Nitta 1994; Bruce and Wiebe 1994), providing information for sense definitions can be a considerable burden.
C92-2070 C94-1049 H93-1051 P91-1017 P91-1019 P91-1034 P94-1020 W93-0102 W96-0104
The fact that the error rate more than doubles when the seeds in Yarowsky's (1995) experiments are reduced from a sense's best collocations to just one word per sense suggests that the error rate would increase further if no seeds were provided.
P95-1026
Many technical terms have nontechnical meanings that are used in addition to more specialized senses even in technical text (e.g., window and application in computer magazines, convertible in automobile magazines \[Krovetz 1997\]).
P97-1010
Yarowsky has proposed an algorithm that requires as little user input as one seed word per sense to start the training process (Yarowsky 1995).
P95-1026
