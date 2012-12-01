Many existing active learning methods are to select the most uncertain examples using various measures (Thompson et al.1999; Schohn and Cohn 2000; Tong and Koller 2000; Engelson and Dagan 1999; Ngai and Yarowsky 2000).
P00-1016
2 Multi-criteria for NER Active Learning Support Vector Machines (SVM) is a powerful machine learning method, which has been applied successfully in NER tasks, such as (Kazama et al.2002; Lee et al.2003). In this paper, we apply active learning methods to a simple and effective SVM model to recognize one class of names at a time, such as protein names, person names, etc.
W02-0301 W03-1305
Based on the assumption that N examples are uniformly distributed between the K clusters, the time complexity of the alg orithm is about O(N2/K+NK) (Tang et al.2002). In one of our experiments, the size of the NESet (N) is around 17000 and K is equal to 50, so the time complexity is about O(106).
P02-1016
(Tang et al.2002) use the density information to weight the selected examples while we use it to select examples.
P02-1016
In order to overcome this difficulty, active learning (sample sele ction) has been studied in more and more NLP applications such as POS tagging (Engelson and Dagan 1999), information extraction (Thompson et al.1999), text classif ication (Lewis and Catlett 1994; McCallum and Nigam 1998; Schohn and Cohn 2000; Tong and Koller 2000; Brinker 2003), statistical parsing (Thompson et al.1999; Tang et al.2002; Steedman et al.2003), noun phrase chunking (Ngai and Yarowsky 2000), etc.
N03-1031 P00-1016 P02-1016
It is probably because NER in the newswire domain is much simpler than that in the biomedical domain (Shen et al.2003) and named entities are less and distributed much sparser in the newswire texts than in the biomedical texts.
W03-1307
(McCallum and Nigam 1998; Tang et al.2002) are the only two works considering the representativeness criterion in active learning.
P02-1016
Many existing work in the area focus on two approaches: certainty-based methods (Thompson et al.1999; Tang et al.2002; Schohn and Cohn 2000; Tong and Koller 2000; Brinker 2003) and committee-based methods (McCallum and Nigam 1998; Engelson and Dagan 1999; Ngai and Yarowsky 2000) to select the most informative examples for which the current model are most uncertain.
P00-1016 P02-1016
There are only a few works considering this selection criterion (McCallum and Nigam 1998; Tang et al.2002) and both of them are specific to their tasks, viz.
P02-1016
Each word in SVM is represented as a high-dimensional feature vector including surface word information, orthographic features, POS feature and semantic trigger features (Shen et al.2003). The semantic trigger features consist of some special head nouns for an entity class which is supplied by users.
W03-1307
