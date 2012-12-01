Although both models yield comparable performance, Turner and Charniak (2005) show that the latter is not an appropriate compression model since it favours uncompressed sentences over compressed ones.1 Hori and Furui’s (2004) model was originally developed for Japanese with spoken text in mind, 1The noisy-channel model uses a source model trained on uncompressed sentences.
P05-1036
Simple String Accuracy (SSA, Bangalore et al.2000) has been proposed as a baseline evaluation metric for natural language generation.
W00-1401
Our results show that grammatical relationsbased F-score (Riezler et al.2003) correlates reliably with human judgements and could thus be used to measure compression performance automatically.
N03-1026
RASP failed on 17 sentences from the Broadcast news corpus and 33 from the Ziff-Davis corpus; Charniak’s (2000) parser successfully parsed the Broadcast News corpus but failed on three sentences from the Ziff-Davis corpus.
A00-2018
The training data for both models was parsed using Charniak’s (2000) parser.
A00-2018
Many algorithms exploit parallel corpora (Jing 2000; Knight and Marcu 2002; Riezler et al.2003; Nguyen et al.2004a; Turner and Charniak 2005; McDonald 2006) to learn the correspondences between long and short sentences in a supervised manner, typically using a rich feature space induced from parse trees.
A00-1043 C04-1107 E06-1038 N03-1026 P05-1036
Ziff-Davis Corpus Most previous work (Jing 2000; Knight and Marcu 2002; Riezler et al.2003; Nguyen et al.2004a; Turner and Charniak 2005; McDonald 2006) has relied on automatically constructed parallel corpora for training and evaluation purposes.
A00-1043 C04-1107 E06-1038 N03-1026 P05-1036
This allows us to measure the semantic aspects of summarisation quality in terms of grammatical-functional information (Riezler et al.2003). The standard metrics of precision, recall and F-score can then be used to measure the quality of a system against a gold standard.
N03-1026
Alternatively, the rules of compression are approximated from a non-parallel corpus (e.g., the Penn Treebank) by considering context-free grammar derivations with matching expansions (Turner and Charniak 2005).
P05-1036
It has inspired many discriminative approaches to the compression task (Riezler et al.2003; Nguyen et al.2004b; McDonald 2006) and has been extended to languages other than English (see Nguyen et al.2004a). We opted for the decisiontree model instead of the also well-known noisychannel model (Knight and Marcu 2002; Turner and Charniak 2005).
C04-1107 E06-1038 N03-1026 P05-1036
For example, to automatically generate subtitles for television programs; the transcripts cannot usually be used verbatim due to the rate of speech being too high (Vandeghinste and Pan 2004).
W04-1015
