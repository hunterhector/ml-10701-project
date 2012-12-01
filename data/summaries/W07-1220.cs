For automatic parsing, we made use of the wellknownCharniakparser(Charniak,2000).
A00-2018
JACY (Siegel and Bender, 2002) is a broadcoverage linguistically precise HPSG-based grammar of Japanese.
W02-1210
In parsing, for example, symbolic grammars are combined with stochastic models (Oepen et al., 2004; Malouf and van Noord, 2004).
P04-1057
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
P04-1057
Although the CHILDES annotation scheme proposed by Sagae et al.(2004) has been used in practice for automatic parsing of child language transcripts (Sagae et al., 2004; Sagae et al., 2005), such work relied mainly on a statistical parser (Charniak, 2000) trained on the Wall Street Journal portion of the Penn Treebank, since a large enough corpus of annotated CHILDES data was not available to train a domain-specific parser.
A00-2018
Baldwin. 2005.
W05-1008 W05-1008
Similarly to Baldwin (2005), the methods are applicable to other constraint-based lexicalist grammars, but no direct measurement of the impact on grammar performance was attempted.
W05-1008
Korhonen (2002), Carroll and Fang (2004), Baldwin (2005), Blunsom and Baldwin (2006), and Zhang and Kordoni (2006) are just a few examples of reported research work on deep lexical acquisition.
W05-1008
With the evolution of the grammar, the treebank as the output from the grammar changes over time (Oepen et al., 2002).
C02-2025
Baldwin (2005) took a statistical approach to automated lexical acquisition for deep grammars.
W05-1008
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
A00-2018
Eugene Charniak. 2000. A maximum-entropy-inspired parser. In Proceedings of NAACL, pages 132139.
A00-2018
??The development of error mining techniques (van Noord, 2004) to identify erroneous and incomplete information in the linguistic resources which cause the grammar to fail.
P04-1057
A similar approach has also been reported in (Johnson et al., 1999; Riezler et al., 2002; Malouf and van Noord, 2004).
P04-1057
Furthermore, to test the grammar precision and accuracy, we use two treebanks: Redwoods (Oepen et al., 2002) for English and Hinoki (Bond et al., 2004) for Japanese.
C02-2025 W04-1901
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P04-1057
Dictionary Compatability The last kind of semantic information we use is valency information, taken from the Japanese side of the Goi-Taikei Japanese-English valency dictionary as extended by Fujita and Bond (2004).This valency dictionary has detailed information about the argument properties of verbs and adjectives, including subcategorization and selectional restrictions.
W04-1901
Generally, the syntactic structure of a sentence is represented as a tree, and parsing is carried out by maximizing the likelihood of the tree (Charniak, 2000; Uchimoto et al., 1999).
A00-2018
This way, we hope to extract the information necessary to model the tendencies observed, e.g., in Uszkoreit et al.(1998). 3.4 Lexicalized properties capturing dependencies Inspired by Malouf and van Noord (2004), we finally also introduced lexicalized properties capturing dependencies.
P04-1057
In recent years, many accurate phrase-structure parsers have been developed (e.g., (Collins, 1999; Charniak, 2000)).
A00-2018
Many researchers have recently developed methods for the automatic acquisition of various properties of MWEs from corpora (Lin, 1999; Krenn and Evert, 2001; Baldwin et al., 2003; McCarthy et al., 2003; Venkatapathy and Joshi, 2005; Villada Moiron and Tiedemann, 2006; Fazly and Stevenson, 2006).
W05-1008
(Rosario and Hearst, 2001; Moldovan et al., 2004; Kim and Baldwin, 2005) use supervised methods and explore classification features from a simple structured type hierarchy.
W05-1008
Erbach (1990), Barg and Walther (1998) and Fouvry (2003) followed a unification-based symbolic approach to unknown word processing for constraint-based grammars.
E03-1041 P98-1014
Oepen. 2002.
C02-2025
Such relations are usually represented as a set of taxonomic categories; for example the meaning of STUDENT LOAN might be specified with a POSSESSOR relation (Kim & Baldwin, 2005) or MILK COW might be specified by a MAKES relation (Gagne & Shoben, 1997).
W05-1008
van Noord (2004)).
P04-1057
Levi, 1977; Kim & Baldwin, 2005).
W05-1008
The grammars used for the experiments reported here are the LinGO English Resource Grammar (ERG; Flickinger (2000)) and JACY (Siegel and Bender, 2002), precision grammars of English and Japanese, respectively.
W02-1210
In this paper, we explore the utility of different evaluation metrics at predicting parse performance through a series of experiments over two broad coverage grammars: the English Resource Grammar (ERG; Flickinger (2000)) and JACY (Siegel and Bender, 2002).
W02-1210
In combination with test suite management software such as [incr tsdb()] (Oepen, 2002), they are used for validation and regression testing of precision (deep linguistic) grammars as well as the exploration of potential changes to the grammar.
C02-2025
that used in the Charniak parser (Charniak, 2000) or the various CCG parsers (Hockenmaier, 2006)).
A00-2018 P06-1064
That work relied on a phrase-structure statistical parser (Charniak, 2000) trained on the Penn Treebank, and the output of that parser had to be converted into CHILDES grammatical relations.
A00-2018
For comparison, Sagae et al.(2005) report 86.9% LAS on about 2,000 words of Eve data, using the Charniak (2000) parser with a separate dependency-labeling step.
A00-2018
E. Charniak, D. Blaheta, N. Ge, K. Hall, and M. Johnson. 2000. BLLIP 198789 WSJ Corpus Release 1, LD No. LDC2000T43. Linguistic Data Consortium.
A00-2018
Gagne & Shoben, 1997; Kim & Baldwin, 2005).
W05-1008
The supertagger was trained on the CCGBank in English (Hockenmaier and Steedman, 2005) and in German (Hockenmaier, 2006).
P06-1064
The grammar is an HPSG implementation (JACY: Siegel and Bender, 2002), which provides a high level of detail, marking not only dependency and constituent structure but also detailed semantic relations.
W02-1210
More recently, there has been an explosion of interest in deep lexical acquisition (DLA; (Baldwin, 2005; Zhang and Kordoni, 2006; van de Cruys, 2006)) for broad-coverage deep grammars, either by exploiting the linguistic information encoded in the grammar itself (in vivo), or by using secondary language resources (in vitro).
W05-1008
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
P04-1057
This parser uses a discriminative reranker that selects the most probable parse from the 50-best parses returned by a generative parser based on Charniak (2000).
A00-2018
For example, the current reported coverage figures on spoken dialogue corpora are close to 90% (Oepen et al., 2002).
C02-2025
BLLIP corpus (Charniak et al., 2000), which con-
A00-2018
