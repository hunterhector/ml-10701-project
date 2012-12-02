There are also two other methods capable of conducting unknown word POS tagging (Ng and Low, 2004): Word-based Post-Processing Method This method receives results of word segmentation and known word POS tagging, and predicts POS tags of unknown words using words as units (Figure 2, B).
W04-3236
For example, ?amerika32 ??wa:Ken22?? is used as the feature of the given pair ?Ken22??and ?amerika32?? 2.5 Classification Algorithm There are several structure-based learning algorithms proposed so far (Collins and Duffy, 2001; Suzuki et al., 2003; Kudo and Matsumoto, 2004).
W04-3230
Ng and Low (2004) studied Chinese word segmentation and POS tagging.
W04-3236
It was reported that the original combined method of word-based and character-based processing had high overall accuracy (F-measures) in Chinese word segmentation, compared with the state-of-the-art methods (Nakagawa, 2004).
C04-1067
Thus, the character-based method was not always better than the word-based method as reported by Ng and Low (2004) when the methods were used with the word and character-based combined approach on Japanese corpora.
W04-3236
Nakagawa (2004) studied a method which combines a word-based method and a character-based method.
C04-1067
Comparing the word-based and the character-based post-processing methods, the F-measures of the latter were higher on the Chinese corpora as reported by Ng and Low (2004), but the F-measures of the former were slightly higher on the Japanese corpora.
W04-3236
This result agrees with the observation by Ng and Low (2004) that higher accuracy was obtained by conducting word segmentation and POS tagging at the same time than by conducting these processing separately.
W04-3236
Kudo et al.(2004) studied Japanese word segmentation and POS tagging using conditional random fields (CRFs) and rulebased unknown word processing.
W04-3230
