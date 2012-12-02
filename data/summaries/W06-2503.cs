There are other methods proposed in the literature which also make use of information in WordNet, particularly looking for senses with related words in common (Tomuro, 2001; Mihalcea and Moldovan, 2001).
N01-1010
This paper describes work to automatically relate WordNet word senses using automatically acquired thesauruses (Lin, 1998) and WordNet similarity measures (Patwardhan and Pedersen, 2003).
P98-2127
While contextual evidence is required for accurate WSD, it is useful to look at this heuristic since it is so widely used as a back-off model by many systems and is hard to beat on an allwords task (Snyder and Palmer, 2004).
W04-0811
One response to this is WNs# gloss 1 your basis for belief or disbelief; knowledge on which to base belief; ‘the evidence that smoking causes lung cancer is very compelling’ 2 an indication that makes something evident; ‘his trembling was evidence of his fear’ 3 (law) all the means by which any alleged matter of fact whose truth is investigated at judicial trial is established or disproved Figure 1: The senses of evidence in WordNet to exploit the natural skew of the data and focus on finding the first (predominant) sense from a sample of text (McCarthy et al., 2004).
P04-1036
Kohomban and Lee (2005) get good results on disambiguation of the SENSEVAL all-words tasks using the 25 unique beginners from the WordNet hierarchy for training a coarse-grained WSD system and then using a first sense heuristic (provided using the frequency 2Mihalcea and Moldovan group WordNet synonym sets (synsets) rather than word senses.
P05-1005
Dolan. 1994.
C94-2113
18 2 Related Work There is a significant amount of previous work on grouping WordNet word senses using a number of different information sources, such as predicate argument structure (Palmer et al., forthcoming), information from WordNet (Mihalcea and Moldovan, 2001; Tomuro, 2001) 2 and other lexical resources (Peters and Peters, 1998) translations, system confusability, topic signature and contextual evidence (Agirre and Lopez de Lacalle, 2003).
N01-1010
There is also work on grouping senses of other inventories using information in the inventory (Dolan, 1994) along with information retrieval techniques (Chen and Chang, 1998).
C94-2113 J98-1003
Measures of distance in the WordNet hierarchy such as JCN have been widely used for WSD (Patwardhan et al., 2003) as well as the information contained in the structure of the hierarchy (Kohomban and Lee, 2005) which has been used for backing off when training a supervised system.
P05-1005
DIST We use a distributional similarity measure (Lin, 1998) to obtain a fixed number (50) of the top ranked nearest neighbours for the target nouns.
P98-2127
Our other method relates to the findings of Kohomban and Lee (2005).
P05-1005
We contrast the performance of first sense heuristics i) from SemCor (Miller et al., 1993) and ii) derived automatically from the BNC following (McCarthy etal., 2004) and also iii) anupper-bound firstsense heuristic extracted from the test data.
H93-1061 P04-1036
Given the lack of a plug and play application for feeding disambiguated data, we hope to examine the benefits on some lexical acquisition tasks that might feed into an application, for example sense ranking (McCarthy et al., 2004) or selectional preference acquisition.
P04-1036
Disambiguation is performed using the first sense heuristic from i) SemCor (Semcor FS) ii) automatic rankings from the BNC produced using the method proposed by McCarthy et al.(2004) (Auto FS) and iii) an upper-bound first sense heuristic from the SEVAL-2 ENG LEX data itself (SEVAL-2 FS).
P04-1036
20 word (#senses) PWA art (4) 44.44 authority (7) 52.38 bar (13) 87.07 bum (4) 100.00 chair (4) 43.75 channel (7) 46.03 child (4) 66.67 circuit (6) 46.67 day (10) 64.44 facility (5) 86.67 fatigue (4) 44.44 feeling (6) 42.22 hearth (3) 55.56 mouth (8) 40.48 nation (4) 100.00 nature (5) 73.33 post (8) 92.86 restraint (6) 42.22 sense (5) 73.33 stress (5) 73.33 overall PWA 66.94 given leniency 88.10 Table 2: Pairwise agreement % senses andthe factthat figures forsense annotation with three judges (as opposed to two, with a third to break ties) are reported in this region (Koeling et al., 2005).
H05-1053
