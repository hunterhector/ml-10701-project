The system tokenizes, tags, lemmatizes and parses input sentences using the recent (second) release of the RASP (Robust Accurate Statistical Parsing) system (Briscoe et al., 2006) which parses arbitrary English text with state-of-the-art levels of accuracy.
P06-4020
by Vlachos and Gasperin (2006)).
W06-3316 W06-3328
Without using other specific domain resources, the system achieves comparable results to some other state-of-the-art systems (Finkel et al., 2004; Settles, 2004) which resort to external knowledge, such as protein dictionaries.
W04-1221
Examples include anaphora resolution (Gasperin, 2006) and gene normalization (Hirschman et al., 2005).
W06-3316
In parallel, there have been successful efforts in bootstrapping NER systems using automatically generated training material using domain resources (Morgan et al., 2004; Vlachos et al., 2006).
W06-3328
The automatically generated corpus was created in order to bootstrap a gene name recognizer in Vlachos & Gasperin (2006).
W06-3316 W06-3328
Moses has shown that it achieves results comparable to the most competitive and widely used statistical machine translation systems in translation quality and run-time (Shen et al.2006). It features all the capabilities of the closed sourced Pharaoh decoder (Koehn 2004).
P04-1075
Vlachos and Gasperin (2006) produced a revised version of the 59 guidelines for the task, and were able to achieve an a0 score of 91%, and a kappa of 0.905, between a computational linguist and a domain expert.
W06-3316 W06-3328
In brief, the abstracts of 16,609 articles curated by FlyBase were retrieved and tokenized by RASP (Briscoe et al., 2006).
P06-4020
Briscoe. 2006.
P06-4020
In order to verify the reliability of baseNP annotation, two computational linguists (re)annotated the 600 sentences (6300 tokens) of Vlachos and Gasperin (2006) with baseNPs and heads using the published guidelines.
W06-3316 W06-3328
Shen et al.(2003), Zhang et al.(2004), and Zhou et al.(2004) all report on a rulebased approach to dealing with nested NEs in the GENIA corpus (Version 3.0) in combination with a Hidden Markov Model (HMM) that first recognises innermost NEs.
P04-1075
(Charniak, 2000; Briscoe et al., 2006), have wide coverage and yield grammatical representations capable of supporting various applications (e.g.
P06-4020
Given the variety of methods that are available for generating training data efficiently automatically using extant domain resources (Morgan et al., 2004) or semi-automatically (active learning approaches like Shen et al.(2004) or systems using seed rules such as Mikheev et al.(1999)), it would be of interest to have a shared task in which the participants would have access to evaluation data only and they would be invited to use such methods to develop their systems.
E99-1001 P04-1075
All our results for NER are reported on the CoNLL-2003 shared task dataset (Tjong Kim Sang and De Meulder, 2003).
W03-0419
Previous best results: FIJZ03 (Florian et al., 2003), CN03 (Chieu and Ng, 2003), KSNM03 (Klein et al., 2003).
W03-0425
Tokenisation and sentence splitting is followed by part-ofspeech tagging with the Maximum Entropy Markov Model (MEMM) tagger developed by Curran and Clark (2003) (hereafter referred to as C&C ) for the CoNLL-2003 shared task (Tjong Kim Sang and De Meulder, 2003), trained on the MedPost data (Smith et al., 2004).
W03-0419
Finaly, combining models has been a successful way of achieving good results, such as those of Florian et al.(2003) who had the top performance in the named entity recognition shared task of CoNLL 2003 (Tjong Kim Sang and De Meulder, 2003).
W03-0419 W03-0425
Vlachos et al.(2006) employed this system and achieved good results on bootstrapping biomedical named entity recognition.
W06-3328
noisy golden full abstracts abstracts papers abstracts / 16,609 82 5 papers sentences 111,820 600 1,220 tokens 2,923,199 15,703 34,383 gene names 117,279 629 2,057 unique 16,944 326 336 gene names unique non60,943 3,018 4,113 gene tokens Table 1: Statistics of the datasets The gene names in both manually created corpora were annotated using the guidelines presented in Vlachos & Gasperin (2006).
W06-3316 W06-3328
2http://www.gate.ac.uk 3http://nlp.stanford.edu/software/tagger.shtml 166 We adopted a similar strategy with the domain independent full parsing system RASP (Briscoe et al., 2006).
P06-4020
Naturally, in the live system, an automated NER process is used (Vlachos and Gasperin, 2006).
W06-3316 W06-3328
Also of interest is the system presented by Settles (2004) which used CRFs with rich feature sets and suggested that one could use features from syntactic parsing with this model given their flexibility.
W04-1221
In order to evaluate the performance of the systems, apart from the standard recall, precision and F-score metrics, we measured the performance on seen and unseen gene names independently, as suggested by Vlachos & Gasperin (2006).
W06-3316 W06-3328
Finally, the BIOEW scheme (Siefkes, 2006) was used to tag the tokenized corpora, under which the first token of a multitoken mention is tagged as B, the last token as E, the inner ones as I, single token mentions as W and tokens outside an entity as O.
N06-2038
We also use the baseNP identi cation in order to type the occurrence semantically and use this information in an anaphora resolution process (Gasperin, 2006).
W06-3316
The manually annotated corpus of abstracts was described in Vlachos & Gasperin (2006).
W06-3316 W06-3328
In this spirit, we didn?t attempt any of the improvements discussed by Vlachos & Gasperin (2006) because they were based on observations on the behavior of the HMM-based system.
W06-3316 W06-3328
Few biomedical corpora exist for other tasks, such as coreference resolution (Casta?no et al., 2004; Vlachos et al., 2006), and these are very small.
W06-3328
However, as explicitly stated by Shen et al.(2003) and Zhang et al.(2004), this evaluation is limited to non-embedded (i.e.
P04-1075
Gasperin. 2006.
W06-3316 W06-3316
Work In previous work addressing nested entities, Shen et al.(2003), Zhang et al.(2004), Zhou et al.(2004), Zhou (2006), and Gu (2006) considered the GENIA 2Both corpora are represented in XML with standoff annotation, potentionally allowing overlapping NEs.
P04-1075
Its main components are the Conditional Random Fields toolkit MALLET2 (McCallum, 2002) and the RASP syntactic parsing toolkit3 (Briscoe et al., 2006), which are both publicly available.
P06-4020
The corpus of Vlachos and Gasperin (2006) contains 80 abstracts (600 sentences) annotated with gene names.
W06-3316 W06-3328
While Shen et al.(2003) and Zhang et al.(2004) report results testing on 4% of the abstracts in the GENIA corpus, Zhou et al.(2004) report 10-fold cross-validation scores.
P04-1075
Vlachos and Gasperin (2006) claim that their name versus mention distinction was helpful in understanding disagreements over gene name extents and this led, through greater clarity of intended coverage, to improved NER.
W06-3316 W06-3328
This resulted in improved inter-annotator agreement (Vlachos et al., 2006).
W06-3328
It is possible that tokens that contain hyphens, brackets and other special characters are more likely to be unknown or rare tokens?the TokenShapeChunker has previously been reported to make most of its mistakes on these (Vlachos and Gasperin, 2006), so tokenising them is likely to make less of an impact.
W06-3316 W06-3328
Statistical approaches (Collier et al., 2000; Kazama et al., 2002; Settles, 2004) typically improve recall at the expense of precision, but are more readily retargetable for new nomenclatures and organisms.
W04-1221
