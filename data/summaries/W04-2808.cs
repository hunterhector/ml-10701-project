Semantic Roles and Relations The task of representing the semantic relations that hold between the sense tagged entities can be thought of as an extension of the work presented by Gildea and Jurafsky (2002), where the tagset is defined by entities corresponding to FrameNet frame elements (Baker et al., 1998).
J02-3001 P98-1013
Historically, after work on WSD had overcome socalled early doubts (Ide and Veronis, 1998) in the 1960’s, it was applied to various NLP tasks, such as machine translation, information retrieval, content and grammatical analysis and text processing.
J98-1001
In general, following Ide and Veronis (1998) the various WSD approaches of the past can be divided into two types, i.e., dataand knowledge-based approaches.
J98-1001
The transition from the former to the later can be regarded as a scaling process, since virtually every processing technique applicable for restricted single domain user utterances has to be adopted to new challenges, i.e., varying context-dependencies (Porzel et al., 2004) increasing levels of ambiguity (Gurevych et al., 2003a; Loos and Porzel, 2004) and less predictable input (Loeckelt et al., 2002).
N03-1012 W03-0903 W04-2312 W04-2802
Data-based Methods Data-based approaches extract their information directly from texts and are divided into supervised and unsupervised methods (Yarowsky, 1995; Stevenson, 2003).
P95-1026
Then, the existing ontology was adopted in the SMARTKOM project (Wahlster et al., 2001) and modified to cover a number of new domains, e.g., new media and program guides, pedestrian and car navigation and more (Gurevych et al., 2003b).
N03-1012 W03-0903
Yarowsky (1995) used both supervised and unsupervised WSD for correct phonetizitation of words in speech synthesis.
P95-1026
Many of these tasks have been addressed in other fields, for example, hypothesis verification in the field of machine translation (Tran et al., 1996), sense disambiguation in speech synthesis (Yarowsky, 1995), and relation tagging in information retrieval (Marsh and Perzanowski, 1999).
P95-1026
The ensuing distance between two concepts, e.g. a0a2a1a4a3a6a5a8a7a9a3a11a10a6a12 is then defined as the minimum score derived between a3a6a5 and a3a11a10 . So far, a number of additional normalization steps, contextual extensions and relation-specific weighted scores have been proposed and evaluated (Gurevych et al., 2003a; Porzel et al., 2003a; Loos and Porzel, 2004) The ONTOSCORE module currently employs two knowledge sources: an ontology (about 800 concepts and 200 relations) and a lexicon (ca.
N03-1012 W03-0903 W04-2312 W04-2802
For example, Yarowsky (1992) used a thesaurus to generate 1042 statistical models of the most general categories.
C92-2070
The modeling of Process as a kind of event that is continuous and homogeneous in nature, follows the frame semantic analysis used in the FRAMENET project (Baker et al., 1998).
P98-1013
Some of these tasks which are not mentioned herein are executed by different processing components that employ the same underlying knowledge model but apply different operations such as overlay and have been reported elsewhere (Alexandersson and Becker, 2001; Gurevych et al., 2003b; Porzel et al., 2003b).
N03-1012 W03-0903
The knowledge-based approach employed herein (Gurevych et al., 2003a) operates on an ontology partially derived from FrameNet data (Baker et al., 1998) and is described by Gurevych et al.(2003b). In a comparable approach Sussna (1993) worked with the lexical reference system WordNet and used a similar metric for the calculation of semantic distance of a number of input lexemes.
N03-1012 P98-1013 W03-0903
Following Ide and Veronis (1998) we distinguish between dataand knowledge-driven word sense disambiguation.
J98-1001
To score the minimal paths connecting all concepts with each other in a given CR, Gurevych et al.(2003a) adopted a method proposed by Demetriou and Atwell (1994) to score the semantic coherence of alternative sentence interpretations against graphs based on the Longman Dictionary of Contemporary English (LDOCE).
N03-1012 W03-0903
Compared to the gold-standard, the original method of Gurevych et al.(2003a) reached a precision of 63.76 a0 as compared to 64.75 a0 for the new method described herein.
N03-1012 W03-0903
Disambiguation 4.1 Data and Annotation The corresponding data collection is described in detail by Gurevych and Porzel (2004).
W04-2802
Corresponding to the frequency of each concept of each ambiguous lexeme the percentage of correctly chosen concepts by means of selecting the most frequent meaning without the help of a system was calculated by means of the formula given by Porzel and Malaka (2004).
W04-2802
One example is the algorithm for clustering by committee described by Pantel and Lin (2003), which automatically discovers word senses from text.
N03-4011
Given the basic distinction between written text and spoken utterances, the only sense disambiguation results performed on speech data stemming from human interactions with dialogue systems have been reported by Loos and Porzel (2004), who compared both dataand knowledge-driven sense disambiguation on the same set of actual speech data.
W04-2312 W04-2802
