The lexicalized reordering model was studied in (Tillmann, 2004; Kumar et al., 2005; Koehn et al., 2005).
H05-1021 N04-4026
For reordering model training, two kinds of parse trees for each foreign sentence in the training corpus were obtained through the Stanford parser (Klein, 2003) and a dependency parser (Zhou, 2000).
P03-1054 W00-1212
A straightforward reordering model used in (Wu, 1996; Zens et al., 2004; Kumar et al., 2005) is to assign constant probabilities to monotone reordering and non-monotone reordering, which can be flexible depending on the different language pairs.
C04-1030 H05-1021 P96-1021
In our system, we combine the parse trees generated respectively by Stanford parser (Klein, 2003) and a dependency parser developed by (Zhou, 2000).
P03-1054 W00-1212
As shown in Figure 2(a), the syntactic tree of Chinese sentence “广东 省 / 高新技术 / 产品 / 出口 ” (Guangdong/hightech/products/export), parsed by the Stanford Parser (Klein, 2003), has a 3-ary sub-tree.
P03-1054
Similar to the default features in Pharaoh (Koehn, Och and Marcu 2003), we used following features to estimate the weight of our grammar rules.
J03-1002 N03-1017 P03-1021
Similar to the work in Chiang (2005), our translation model can be formulated as a weighted synchronous context free grammar derivation process.
P05-1033
Similar to most state-of-the-art phrase-based SMT systems, we use the SRI toolkit (Stolcke, 2002) for language model training and Giza++ toolkit (Och and Ney, 2003) for word alignment.
J03-1002 P03-1021
A hierarchical phrase-based model was proposed by (Chiang, 2005).
P05-1033
In phrase-based SMT systems (Koehn et al., 2003; Koehn, 2004), foreign sentences are firstly segmented into phrases which consists of adjacent words.
N03-1017
Xiong’s system (Xiong, et al., 2006) which used ME model to train the reordering model is also regarded as a competitor.
P06-1066
On the other hand, syntax-based SMT systems (Liu et al., 2006; Yamada et al., 2001) mainly depend on parse trees to complete the translation of source sentence.
P01-1067 P06-1077
For Rule (3)~(9), according to the syntactic structures, their application is determined since there is only one choice to complete reordering, which is similar to the “glue rules” in Chiang (2005).
P05-1033
Beyond standard phrase-based SMT system, a CKY style decoder was developed in (Xiong et al., 2006).
P06-1066
Although syntax-based SMT systems (Yamada et al., 2001; Quirk et al., 2005; Liu et al., 2006) are good at modeling global reordering, their performance is subject to parsing errors to a large extent.
P01-1067 P05-1034 P06-1077
There have been considerable amount of efforts to improve the reordering model in SMT systems, ranging from the fundamental distance-based distortion model (Och and Ney, 2004; Koehn et al., 2003), flat reordering model (Wu, 1996; Zens et al., 2004; Kumar et al., 2005), to lexicalized reordering model (Tillmann, 2004; Kumar et al., 2005; Koehn et al., 2005), hierarchical phrase-based model (Chiang, 2005), and maximum entropy-based phrase reordering model (Xiong et al., 2006).
C04-1030 H05-1021 J03-1002 J04-4002 N03-1017 N04-4026 P03-1021 P05-1033 P06-1066 P96-1021
In our model, we make use of bilingual phrases as well, which refer to source-target aligned phrase pairs extracted using the same criterion as most phrase-based systems (Och and Ney, 2004).
J04-4002
Based on the word alignment results, if the aligned target words of any two adjacent foreign linguistic phrases can also be formed into two valid adjacent phrase according to constraints proposed in the phrase extraction algorithm by Och (2003a), they will be extracted as a reordering training sample.
J03-1002 P03-1021
Syntax-based SMT systems (Yamada et al., 2001; Quirk et al., 2005; Liu et al., 2006) totally depend on syntax structures to complete phrase translation.
P01-1067 P05-1034 P06-1077
We just assign these rules a constant score trained using our implementation of Minimum Error Rate Training (Och, 2003b), which is 0.7 in our system.
J03-1002 P03-1021
