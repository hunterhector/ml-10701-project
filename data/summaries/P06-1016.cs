Miller et al (2000) augmented syntactic full parse trees with semantic information of entities and relations, and built generative models to integrate various tasks such as POS tagging, named entity recognition, template element extraction and relation extraction.
A00-2030
Bunescu and Mooney (2005b) proposed a subsequence kernel and ap1 The ACE RDC 2003 corpus defines 5/24 relation types/subtypes between 4 entity types.
H05-1091
Roth and Yih (2002) used the SNoW classifier to incorporate various features such as word, part-of-speech and semantic information from WordNet, and proposed a probabilistic reasoning approach to integrate named entity recognition and relation extraction.
C02-1151
To overcome the data sparseness problem, generative models typically applied some smoothing techniques to integrate different scales of contexts in parameter estimation, e.g. the back-off approach in Miller et al (2000).
A00-2030
This will be done by integrating the relation extraction system with our previously developed NER system as described in Zhou and Su (2002).
P02-1060
In summary, although various approaches have been employed in relation extraction, they implicitly attack the data sparseness problem by using features of different contexts in featurebased approaches or including different sub2 Here, we classify this paper into feature-based approaches since the feature space in the kernels of Zhao and Grisman (2005) can be easily represented by an explicit feature vector.
P05-1052
While various machine learning approaches, such as generative modeling (Miller et al 2000), maximum entropy (Kambhatla 2004) and support vector machines (Zhao and Grisman 2005; Zhou et al 2005), have been applied in the relation extraction task, no explicit learning strategy is proposed to deal with the inherent data sparseness problem caused by the much uneven distribution among different relations.
A00-2030 P04-3022 P05-1052 P05-1053
Typical works include Miller et al (2000), Zelenko et al (2003), Culotta and Sorensen (2004), Bunescu and Mooney (2005a), Bunescu and Mooney (2005b), Zhang et al (2005), Roth and Yih (2002), Kambhatla (2004), Zhao and Grisman (2005) and Zhou et al (2005).
A00-2030 C02-1151 H05-1091 P04-1054 P04-3022 P05-1052 P05-1053
Kambhatla (2004) employed maximum entropy models with features derived from word, entity type, mention level, overlap, dependency tree, parse tree and achieved Fmeasure of 52.8 on the 24 relation subtypes in the ACE RDC 2003 corpus.
P04-3022
10 20 30 40 50 60 70 2 00 40 0 60 0 80 0 10 0 0 1 20 0 14 0 0 1 60 0 18 0 0 2 00 0 Training Data Size F m e as ur e HS: General-Staff FS: General-Staff HS: Part-Of FS: Part-Of HS: Located FS: Located Figure 2: Learning curve of the hierarchical strategy and its comparison with the flat strategy for some major relation subtypes (Note: FS for the flat strategy and HS for the hierarchical strategy) Performance System P R F Our: Perceptron Algorithm + Hierarchical Strategy 63.6 53.6 58.2 Zhou et al (2005): SVM + Flat Strategy 63.1 49.5 55.5 Kambhatla (2004): Maximum Entropy + Flat Strategy 63.5 45.2 52.8 Table 5: Comparison of our system with other best-reported systems 127 5 Conclusion This paper proposes a novel hierarchical learning strategy to deal with the data sparseness problem in relation extraction by modeling the commonality among related classes.
P04-3022 P05-1053
Finally, we also compare our system with the previous best-reported systems, such as Kambhatla (2004) and Zhou et al (2005).
P04-3022 P05-1053
Zhao and Grisman (2005) 2 combined various kinds of knowledge from tokenization, sentence parsing and deep dependency analysis through support vector machines and achieved F-measure of 70.1 on the 7 relation types of the ACE RDC 2004 corpus 3 . Zhou et al (2005) further systematically explored diverse lexical, syntactic and semantic features through support vector machines and achieved Fmeasure of 68.1 and 55.5 on the 5 relation types and the 24 relation subtypes in the ACE RDC 2003 corpus respectively.
P05-1052 P05-1053
One major challenge in relation extraction is due to the data sparseness problem (Zhou et al 2005).
P05-1053
For comparison, we also adopt the same feature set as Zhou et al (2005): word, entity type, 125 mention level, overlap, base phrase chunking, dependency tree, parse tree and semantic information.
P05-1053
Culotta and Sorensen (2004) extended this work to estimate kernel functions between augmented dependency trees and achieved Fmeasure of 45.8 on the 5 relation types in the ACE RDC 2003 corpus 1. Bunescu and Mooney (2005a) proposed a shortest path dependency kernel.
H05-1091 P04-1054
Same as Zhou et al (2005), we only model explicit relations and explicitly model the argument order of the two mentions involved.
P05-1053
