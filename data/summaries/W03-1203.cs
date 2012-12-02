To evaluate the effectiveness of our method as a foundation for extractive summarization, we extract sentences from each theme class in each document using four features, namely: (1) the position of the sentence np 1= -the further it is from the title, the less important it is supposed to be; (2) the cosine similarity of the sentence with the centroid of its class ψ1; (3) its similarity with the first sentence in the article ψ2; and (4) the so-called Z model (Zechner (1996), Nomoto & Matsumoto (2000)), where the mass of a sentence is computed as the sum of tf, idf values of index terms in that sentence and the center of mass is chosen as the salient sentence to be included in a summary.
C96-2166
Unsupervised methods or hybrids of supervised and unsupervised methods for extractive summarization have been found to yield promising results that are either comparable or superior to supervised methods (Nomoto & Matsumoto (2001,2002)).
P02-1059
Various heuristics and revision strategies have been applied to the general sentence selection schema to take into consideration text cohesion (White & Cardie (2002), Mani and Bloedorn (1999), Aone et.
W02-0402
al (1999), Zha (2002), Barzilay et al., (2001)).
H01-1065
Story segmentation, document and sentence and classification can often be accomplished by unsupervised, clustering methods, with little or no requirement of human labeled data (Deerwester (1991), White & Cardie (2002), Jing et.
W02-0402
For example, Mani (1999) uses spread activation weight between sentence links, (Barzilay et al, 2001) uses a cohesion constraint that led to improvement in summary quality.
H01-1065
Various similarity measures and metrics include the cosine measure, Dice coefficient, Jaccard coefficient, inclusion coefficient, Euclidean distance, KL convergence, information radius, etc (Manning & Scha0 tze (1999), Dagan et al.(1997), Salton and McGill (1983)).
P97-1008
In these works, vector space models are used and document or sentence vectors are clustered together according to some similarity measure (Deerwester (1991), Dagan et al.(1997)). The disadvantage of clustering methods lies in their ad hoc nature.
P97-1008
Hearst. 1994.
P94-1002
al, (2000), Nomoto & Matsumoto (2001,2002), Zha (2002), Osborne (2002)), or followed by a synthesis stage to generate a more natural summary (McKeown & Radev (1999), Hovy & Lin (1999)).
P02-1059 W02-0401
We find that extrinsic, task-oriented evaluation method to be most easily automated, and quantifiable (Radev 2000).
W00-0403
Our task is similar to the concept of discourse parsing (Marcu (1997)), where discourse structures are extracted from the text.
P97-1013
