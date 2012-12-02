We first used the publicly available GIZA++ (Och and Ney, 2003) software to induce English-German word alignments.
J03-1002
Although potentially useful as a proxy for semantic equivalence, automatically induced alignments are often noisy, thus leading to errors in annotation projection (Yarowsky et al., 2001).
H01-1035
For the constituent-based models, constituent information was obtained from the output of Collins’ parser (1997) for English and Dubey’s parser (2004) for German.
P97-1003
Analogously to Hwa etal.(2002),weinvestigatewhetherthereareindeed semantic correspondences between two languages, since there is little hope for projecting meaningful annotations in nonparallel semantic structures.
P02-1050
The availability of rich annotations for the surface realisation of semantic roles has triggered interest in semantic parsing and enabled the development of data-driven models (e.g., Gildea and Jurafsky, 2002).
J02-3001
This procedure produces a realistic corpus sample for the role projection task; similar samples can be drawn for new language pairs using either existing bilingual dictionaries (Fung and Chen, 2004) or automaticallyconstructedsemanticlexicons(Padóand Lapata, 2005).
C04-1134
Words were 864 Model Precision Recall F-score w 0.41 0.40 0.41 cw 0.46 0.45 0.46 Upper bound 0.85 0.84 0.84 Table 6: Results for word-based projection models aligned using the default setting4 of GIZA++ (Och and Ney, 2003), a publicly available implementation of the IBM models and HMM word alignment models.
J03-1002
Hwa et al.(2002) assess the degree of syntactic parallelism in dependency relations between English and Chinese.
P02-1050
Smith and Smith (2004) explore syntactic projection further by proposing an English-Korean bilingual parser integrated with a word translation model.
W04-3207
The challenge is recognised by Fung and Chen (2004) who construct a Chinese FrameNet by mapping English FrameNet entries to concepts listed in HowNet2, an on-line ontology for Chinese, however without exploiting parallel texts.
C04-1134
For the above reasons, our sample selection procedure was informed by two existing resources, the English FrameNet and SALSA, a FrameNetcompatible database for German currently under development (Erk et al., 2003).
P03-1068
In future work, this problem could be handled with explicit identification of empty categories (see Dienes and Dubey, 2003).
W03-1005
Similarly to previous work (Hwa et al., 2002), we find that some mileage can be gained by assuming direct correspondence between two languages.
P02-1050
Yarowsky et al.(2001) propose several projection algorithms for deriving monolingual tools (ranging from part-ofspeech taggers, to chunkers and morphological analysers) without additional annotation cost.
H01-1035
For instance, information extraction (Surdeanu et al., 2003), question answering (Narayanan and Harabagiu, 2004) and machine translation (Boas, 2002) could stand to benefit from broad coverage semantic processing.
C04-1100 P03-1002
Similarly to Fung and Chen (2004) we automatically inducesemanticroleannotationsforatargetlanguage.
C04-1134
