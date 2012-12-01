The system tokenizes, tags, lemmatizes and parses input sentences using the recent (second) release of the RASP (Robust Accurate Statistical Parsing) system (Briscoe et al., 2006) which parses arbitrary English text with state-of-the-art levels of accuracy.
P06-4020
by Vlachos and Gasperin (2006)).
W06-3316 W06-3328
Base noun phrases (baseNPs), broadly the initial portions of non-recursive noun phrases up to the head (Ramshaw and Marcus, 1995), are valuable pieces of linguistic structure which minimally extend beyond the scope of named entities.
W95-0107
A similar approach albeit in a CRF framework is described in Song et al.(2005). The concept of baseNP has undergone a number of revisions (Ramshaw and Marcus, 1995; Tjong Kim Sang and Buchholz, 2000) but has previously always been tied to extraction from a more completely annotated treebank, whose annotations are subject to other pressures than just initial material up to the head . To our knowledge, our gures for inter-annotator agreement on the baseNP task itself 169 (i.e.
C00-2124 W00-0726 W95-0107
The difficulty of this task is that the standard method for converting NER to a sequence tagging problem with BIOencoding (Ramshaw and Marcus, 1995), where each 1http://www.nist.gov/speech/tests/ace/ index.htm token is assigned a tag to indicate whether it is at the beginning (B), inside (I), or outside (O) of an entity, is not directly applicable when tokens belong to more than one entity.
W95-0107
Vlachos and Gasperin (2006) produced a revised version of the 59 guidelines for the task, and were able to achieve an a0 score of 91%, and a kappa of 0.905, between a computational linguist and a domain expert.
W06-3316 W06-3328
In order to verify the reliability of baseNP annotation, two computational linguists (re)annotated the 600 sentences (6300 tokens) of Vlachos and Gasperin (2006) with baseNPs and heads using the published guidelines.
W06-3316 W06-3328
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
P06-4020
Rule-based systems (Fukuda et al., 1998; Hanisch et al., 2003; Yamamoto et al., 2003) that use dictionaries tend to exhibit high precision in tagging named entities but generally with lower tagging recall.
W03-1309
Yamamoto et al (2003) describe an SVM approach to protein name recognition, one of whose features is the output of a baseNP recognizer.
W03-1309
2http://www.gate.ac.uk 3http://nlp.stanford.edu/software/tagger.shtml 166 We adopted a similar strategy with the domain independent full parsing system RASP (Briscoe et al., 2006).
P06-4020
Naturally, in the live system, an automated NER process is used (Vlachos and Gasperin, 2006).
W06-3316 W06-3328
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
N03-1033
We also use the baseNP identi cation in order to type the occurrence semantically and use this information in an anaphora resolution process (Gasperin, 2006).
W06-3316
This is essentially a simple version of the strategy mooted by Toutanova at el (2003) that the traditional order of NER and tagging be reversed.
N03-1033
This result exceeds Lafferty et al.'s accuracy of 95.73% using a CRF but falls short of Toutanova et al.(2003)'s state-of-the-art 97.24%.
N03-1033
Ramshaw and Marcus (1995) state that a baseNP aims to identify essentially the initial portions of nonrecursive noun phrases up to the head, including determiners but not including postmodifying prepositional phrases or clauses . However, work on baseNPs has essentially always proceeded via algorithmic extraction from fully parsed corpora such as the Penn Treebank.
W95-0107
Gasperin. 2006.
W06-3316
First, it recognizes non-recursive Base Noun Phrase (BNP) (our specifications for BNP resemble those in Ramshaw and Marcus 1995).
W95-0107
The corpus of Vlachos and Gasperin (2006) contains 80 abstracts (600 sentences) annotated with gene names.
W06-3316 W06-3328
Tjong Kim Sang, Sabine Buchholz, Introduction to the CoNLL-2000 shared task: chunking, Proceedings of the 2nd workshop on Learning language in logic and the 4th conference on Computational natural language learning, September 13-14, 2000, Lisbon, Portugal 16 Jianping Zhang, Selecting typical instances in instance-based learning, Proceedings of the ninth international workshop on Machine learning, p.470-479, July 1992, Aberdeen, Scotland, United Kingdom
C00-2124 W00-0726
Vlachos and Gasperin (2006) claim that their name versus mention distinction was helpful in understanding disagreements over gene name extents and this led, through greater clarity of intended coverage, to improved NER.
W06-3316 W06-3328
Tjong Kim Sang, Sabine Buchholz, Introduction to the CoNLL-2000 shared task: chunking, Proceedings of the 2nd workshop on Learning language in logic and the 4th conference on Computational natural language learning, September 13-14, 2000, Lisbon, Portugal 18 Erik F.
C00-2124 W00-0726
(Yamamoto et al., 2003) proposed the use of morphological analysis to improve protein name tagging.
W03-1309
It is possible that tokens that contain hyphens, brackets and other special characters are more likely to be unknown or rare tokens?the TokenShapeChunker has previously been reported to make most of its mistakes on these (Vlachos and Gasperin, 2006), so tokenising them is likely to make less of an impact.
W06-3316 W06-3328
For our experiments we use the CoNLL-2000 shared task dataset (Tjong Kim Sang and Buchholz, 2000).
C00-2124 W00-0726
