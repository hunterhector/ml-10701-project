Word segmentation by characterbased tagging is firstly introduced by (Xue and Converse, 2002).
W02-1815
We used CRF-based word segmenter which relaxes the problem (Kudo and Matsumoto, 2004).
W04-3230
One of the solutions is character-based tagging (Xue and Converse, 2002) (Goh et al., 2004a).
W02-1815 W04-1109
(Peng and McCallum, 2004) proposed OOV word extraction methods based on CRF-based word segmenter.
C04-1081
Model b is our previous method proposed in (Goh et al., 2004b): First, a MaxEnt classifier is used to perform character-based tagging to identify OOV words in the test data.
W04-1109
First and second OOV extraction modules use the output of a Maximam Entropy Markov Model (MEMM)-based word segmenter (McCallum et al., 2000) (Uchimoto et al., 2001).
W01-0512
(Nakagawa, 2004) proposed integration of word and OOV word position tag in a trellis.
C04-1067
CRF-based word segmenter is robust to length-bias problem (Kudo and Matsumoto, 2004) by the global normalization.
W04-3230
For example, (Uchimoto et al., 2001) embeded OOV models in MEMM-based word segmenter (with POS tagging).
W01-0512
2.4 CRF-based word segmenter Final word segmentation is carried out by a CRF-based word segmenter (Kudo and Matsumoto, 2004) (Peng and McCallum, 2004).
C04-1081 W04-3230
We use two chunkers: based on SVM (Kudo and Matsumoto, 2001) and CRF (Lafferty et al., 2001).
N01-1025
The details of the model can be found in (Goh et al., 2004b).
W04-1109
Defining some hand written rules to prune false OOV words will help to improve the IV word segmentation (Goh et al., 2004b), because the precision of OOV word extraction becomes higher.
W04-1109
