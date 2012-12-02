The number of types increases with the corpus size, and (Ravichandran et al., 2005) propose heuristics for thesaurus building without undertaking the complete calculation.
P05-1077
type, subcorpora and keywords Where a corpus has components of different text types, users often ask: “what words are distinctive of a particular text type”, “what are the keywords?”.7 Computations of this kind often give unhelpful results because of the ‘lumpiness’ of word distributions: a word will often appear many times in an individual text, so statistics designed to find words which are distinctively different between text types will give high values for words which happen to be the topic of just one particular text (Church, 2000).
C00-1027
It is explored extensively in (Curran, 2004; Weeds and Weir, 2005).
J05-4002
The line of reasoning is explored further by (Gorman and Curran, 2006), who argue that the complete calculation is not realistic given large corpora.
P06-1046
Following initial work by (Sp¨arck Jones, 1964) and (Grefenstette, 1994), an early, online distributional thesaurus presented in (Lin, 1998) has been widely used and cited, and numerous authors since have explored thesaurus properties and parameters: see survey component of (Weeds and Weir, 2005).
J05-4002 P98-2127
7The well-established WordSmith corpus tool (http://www.lexically.net/wordsmith) has a keywords function which has been very widely used, see e.g., (Berber Sardinha, 2000).
W00-0902
We experimented with the 100M-word BNC2, 1Bword Oxford English Corpus3 (OEC), and 1.9Bword Itwac (Baroni and Kilgarriff, 2006).
E06-2001
c©2007 Association for Computational Linguistics An efficient algorithm for building a distributional thesaurus (and other Sketch Engine developments) Pavel Rychl´y Masaryk University Brno, Czech Republic pary@fi.muni.cz Adam Kilgarriff Lexical Computing Ltd Brighton, UK adam@lexmasterclass.com Abstract Gorman and Curran (2006) argue that thesaurus generation for billion+-word corpora is problematic as the full computation takes many days.
P06-1046
