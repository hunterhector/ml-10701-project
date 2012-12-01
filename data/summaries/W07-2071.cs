In the spelling correction task, the 1The McCarthy et al.(2004) system needs to first generate a distributional thesaurus from the target text (if it is large enough?a few million words) or from another large text with a distribution of senses similar to the target text.
P04-1036
OntoNotes (Hovy et al., 2006) is a project that has annotated several layers of semantic information ??including word senses, at a high inter-annotator agreement of over 90%.
N06-2015
For instance, in the OntoNotes project (Hovy et al., 2006) senses are grouped until a 90% inter-annotator agreement is achieved.
N06-2015
subcategorization, lexical classes) can now be acquired automatically from parsed data (McCarthy and Carroll, 2003; Schulte im Walde, 2006; Preiss et al., 2007).
W07-2009
Chinese?English Lexical Sample Task The Multilingual Chinese?English Lexical Sample Task training and test data (Jin et al., 2007) have 2686 and 935 instances respectively for 40 target words (19 nouns and 21 verbs).
W07-2004
c2007 Association for Computational Linguistics Sussx: WSD using Automatically Acquired Predominant Senses Rob Koeling and Diana McCarthy Department of Informatics University of Sussex Brighton BN1 9QJ, UK robk,dianam@sussex.ac.uk 1 Introduction We introduced a method for discovering the predominant sense of words automatically using raw (unlabelled) text in (McCarthy et al., 2004) and participated with this system in SENSEVAL3.
P04-1036
Like (McCarthy et al., 2004) we use k = 50 and obtain our thesaurus using the distributional similarity metric described by (Lin, 1998) and we use WordNet (WN) as our sense inventory.
P04-1036
Mohammad and Hirst (2006a) proposed a way to determine the strength of association between a sense or concept and co-occurring words?the distributional profile of a concept (DPC)?without the use of manually annotated data.
E06-1016 W06-1605
Among others we can mention eXtended WordNet (Mihalcea and Moldovan, 2001), large collections of semantic preferences acquired from SemCor (Agirre and Martinez, 2001; Agirre and Martinez, 2002) or acquired from British National Corpus (BNC) (McCarthy, 2001), largescale Topic Signatures for each synset acquired from the web (Agirre and de la Calle, 2004) or acquired from the BNC (Cuadros et al., 2005).
P04-1036
First, two estimates of importance on words have been used very successfully both in generic and query-focused summarization: frequency (Luhn, 1958; Nenkova et al., 2006; Vanderwende et al., 2006) and loglikelihood ratio (Lin and Hovy, 2000; Conroy et al., 2006; Lacatusu et al., 2006).
N06-2015
In our previous work (Mohammad and Hirst, 2006a), we proposed an unsupervised approach to determine the strength of association between a sense or concept and its co-occurring words?the distributional profile of a concept (DPC)?relying simply on raw text and a published thesaurus.
E06-1016 W06-1605
A new bootstrapped WCCM is created such that each cell mi j, corresponding to word weni and concept cenj, is populated with the number of times weni co-occurs with any word used in sense cenj . Mohammad and Hirst (2006a) used the DPCs created from the bootstrapped WCCM to attain near-upper-bound results in the task of determining word sense dominance.
E06-1016 W06-1605
Word Training Test Rare Senses Baseline Frequent Senses ruling 5,482 200 3.5% 60% an authoritative decision to exert control, or influence space 9,136 200 0% 56% area, volume outer space suit/s 7,467 200 12.5% 57% an action or process in a court a set of garments tank/s 3,909 200 4.5% 90% a combat vehicle a receptacle for liquids train/s 4,271 200 1.5% 74% a line of railroad cars to teach vessel/s 1,618 144 13.9% 69% a ship or plane a tube or canal (as an artery) Artificial ambiguous words or pseudowords are a convenient means of testing disambiguation algorithms (Schtitze 1992a; Gale, Church, and Yarowsky 1992).
C92-2070
Lexical Substitution The English Lexical Substitution Task (McCarthy and Navigli, 2007), for both human annotators and systems is to replace a target word in a sentence with as close a word as possible.
W07-2009
The texts come from the WallStreetJournalcorpus, andwerehand-annotated with OntoNotes senses (Hovy et al., 2006).
N06-2015
The details of the subtasks and scoring can be found in (McCarthy and Navigli, 2007).
W07-2009
WordNet 2.1 is used as the sense inventory for most of the target words, but certain words have one or more senses from OntoNotes (Hovy et al., 2006).
N06-2015
These categories are used to label paragraphs with topics, effectively repeating Yarowsky's (1992) experiments using the their categories rather than Roget's thesaurus.
C92-2070
Other alternative sets of supersenses can be created by an arbitrary cut through the WORDNET hierarchy near the top, or by using topics from a thesaurus such as Roget's (Yarowsky, 1992).
C92-2070
However, as substantiated by experiments by Mohammad et al.(2007), our algorithm is able to handle the added ambiguity.
D07-1060
Mohammad et al.(2007) proposed a way to create cross-lingual distributional profiles of a concepts (CL-DPCs)?? the strengths of association between the concepts of one language and words of another.
D07-1060
Yarowsky. 1992.
C92-2070
Hovy. 2006.
N06-2015
This is similar to how Yarowsky (1992) identifies words that are indicative of a particular sense of the target word.
C92-2070
The categories in a published thesaurus were used as coarse senses or concepts (Yarowsky, 1992).
C92-2070
In English, the OntoNotes project (Hovy et al., 2006) is combining sense tags with the Penn treebank.
N06-2015
Regardless of whether it takes the form of dictionaries (Lesk 1986; Guthrie et al.1991; Dagan, Itai, and Schwall 1991; Karov and Edelman 1996), thesauri (Yarowsky 1992; Walker and Amsler 1986), bilingual corpora (Brown et al.1991; Church and Gale 1991), or hand-labeled training sets (Hearst 1991; Leacock, Towell, and Voorhees 1993; Niwa and Nitta 1994; Bruce and Wiebe 1994), providing information for sense definitions can be a considerable burden.
C92-2070
Sense Acquisition We use the method described in (McCarthy et al., 2004) for nding predominant senses from raw text.
P04-1036
McCarthy. 2007.
W07-2009
Mohammad and Hirst (2006a) and Mohammad et al.(2007) proposed ways to determine these counts in a monolingual and cross-lingual framework without the use of senseannotated data.
D07-1060 E06-1016 W06-1605
Kelly and Stone (1975) consider hand-constructed disambiguation rules; Lesk (1986), Krovetz and Croft (1989), Guthrie et al.(1991), and Karov and Edelman (1996) use on-line dictionaries; Hirst (1987) constructs knowledge bases; Cottrell (1989) uses syntactic and semantic structure encoded in a connectionist net; Brown et al.(1991) and Church and Gale (1991) exploit bilingual corpora; Dagan, Itai, and Schwall (1991) use a bilingual dictionary; Hearst (1991), Leacock, Towell, and Voorhees (1993), Niwa and Nitta (1994), and Bruce and Wiebe (1994) exploit a hand-labeled training set; and Yarowsky (1992) and Walker and Amsler (1986) perform computations based on a hand-constructed semantic categorization of words (Roget's Thesaurus and Longman's subject codes, respectively).
C92-2070
The object of the Lexical Substitution Task (McCarthy and Navigli, 2007) is to replace a target word in a sentence with a suitable substitute that preserves the meaning of the utterance.
W07-2009
Lexical Substitution Task The English Lexical Substitution Task has 1710 test instances for 171 target words (nouns, verbs, adjectives, and adverbs) (McCarthy and Navigli, 2007).
W07-2009
Mohammad and Hirst (2006b) used the DPC-based monolingual distributional measures of concept-distance to rank word pairs by their semantic similarity and to correct real-word spelling errors, attaining markedly better results than monolingual distributional measures of word-distance.
E06-1016 W06-1605
We use the WN Similarity jcn score (Jiang and Conrath, 1997) since this gave reasonable results for (McCarthy et al., 2004) and it is ef cient at run time given precompilation of frequency information.
P04-1036
Overall, however, this data indicates that the approach suggested by (Palmer, 2000) and that is being adopted in the ongoing OntoNotes project (Hovy et al., 2006) does result in higher system performance.
N06-2015
Our nave Bayes classifier scored highest of all unsupervised systems taking part in the task (Jin et al., 2007).
W07-2004
objective ??have attracted considerable attention in the recent years (Hu and Liu, 2004; Kim and Hovy, 2005; Riloff et al., 2006; Turney and Littman, 2003; Yu and Hatzivassiloglou, 2003).
N06-2015
Gale, Church and Yarowsky (1992) formed a hypothesis that ambiguous words have a strong tendency of keeping a single meaning in the same 13 text/discourse.
C92-2070
On average there were 223 training and 49 testing instances for each word tagged with an OntoNote sense tag (Hovy et al., 2006).
N06-2015
Unlike the McCarthy et al.(2004) dominance system, this approach can be applied to much smaller target texts (a few hundred sentences) without the need for a large similarly-sense-distributed text1.
P04-1036
The top part of Table 1 gives the breakdown of the best score, see (McCarthy and Navigli, 2007) for details.
W07-2009
Mohammad et al.(2007) combined German text with an English thesaurus using a German?English bilingual lexicon to create German?English DPCs.
D07-1060
English Lexical Sample Task (Jin et al., 2007) is to select from a given list a suitable English translation of a Chinese target word in context.
W07-2004
