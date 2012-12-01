Oh and Choi (2002) revise this method by introducing binding, in which many to many correspondences are allowed.
C02-1099
In addition, some recent studies investigate discriminative transliteration methods (Klementiev and Roth, 2006; Zelenko and Aone, 2006) in which each segment of the source can be aligned to each segment of the target, where some restrictive conditions based on the distance of the segments and phonetic similarities are applied.
P06-1103 W06-1672
Alignment has also been investigated for transliteration by adopting Covington’s algorithm on cognate identification (Covington, 1996); this is a character alignment algorithm based on matching or skipping of characters, with a manually assigned cost of association.
J96-4002
Covington. 1996.
J96-4002
Most transliteration methods reported in the literature — either graphemeor phoneme-based — use n-grams (AbdulJaleel and Larkey, 2003; Jung et al., 2000).
C00-1056
Transliteration methods can be categorized into grapheme-based (AbdulJaleel and Larkey, 2003; Li et al., 2004), phoneme-based (Knight and Graehl, 1998; Jung et al., 2000), and combined (Bilac and Tanaka, 2005) approaches.
C00-1056 J98-4003 P04-1021
A simple ngram based method works only on single characters (unigram) and transformation rules are defined as si → tj, while an advanced method may take the surrounding context into account (Jung et al., 2000).
C00-1056
Other transliteration systems focus on alignment for transliteration, for example the joint sourcechannel model suggested by Li et al.(2004). Their method outperforms the noisy channel model in direct orthographical mapping for English-Chinese transliteration.
P04-1021
Gao et al.(2004) argue that precise alignment can improve transliteration effectiveness, experimenting on English-Chinese data and comparing IBM models (Brown et al., 1993) with phonemebased alignments using direct probabilities.
J93-2003
From this perspective, past work is roughly divided into those methods which apply a word alignment tool such as GIZA++ (Och and Ney, 2003), and approaches that combine the alignment step into their main transliteration process.
J03-1002
Transliteration methods that use GIZA++ as their word pair aligner (AbdulJaleel and Larkey, 2003; Virga and Khudanpur, 2003; Karimi et al., 2006) have based their work on the assumption that the provided alignments are reliable.
W03-1508
