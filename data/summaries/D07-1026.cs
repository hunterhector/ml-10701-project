Tanev and Magnini (2006) proposed a variant of the Class-Word algorithm, called Class-Example, that relies on syntactic features extracted from corpus and uses as an additional input a set of training examples for each class.
E06-1003
Domain aspects are captured by the domain kernel, described in Section 3.1, while syntagmatic aspects are taken into account by the syntagmatic kernel, presented in Section 3.2. 3Some recent works (Zhao and Grishman, 2005; Gliozzo et al., 2005) empirically demostrate the effectiveness of combining kernels in this way, showing that the combined kernel always improves the performance of the individual ones.
P05-1050 P05-1052
Second, the large availability of manually constructed substitution lexica, such as WordNet (Fellbaum, 1998), or the use of repositories based on statistical word similarities, such as the database constructed by Lin (1998), allows us to find an adequate substitution lexicon for each target word in most of the cases.
P98-2127
We refer to (Giuliano et al., 2006) for a detailed description of the syntagmatic kernel.
W06-2608
As a reference for a comparison of the outcomes of this study, we used the results presented in (Tanev and Magnini, 2006) for the Class-Word and ClassExample approaches.
E06-1003
The syntagmatic kernel, proposed by Gliozzo et al.(2005), is an attempt to solve this problem.
P05-1050
It is worthwhile to remark here that, being the IBLE algorithm fully unsupervised, improving the most frequent baseline is an excellent result, rarely achieved in the literature on unsupervised methods for WSD (McCarthy et al., 2004).
P04-1036
Therefore, in the literature, the fine-grained classification task has been approached by adopting weakly supervised (Tanev and Magnini, 2006; Fleischman and Hovy, 2002) or unsupervised methods (Cimiano and V¨olker, 2005).
C02-1130 E06-1003
Tanev and Magnini (2006) proposed a weakly supervised method that requires as training data a list of terms without context for each class under consideration.
E06-1003
In addition, we also compared it to a supervised approach (Tanev and Magnini, 2006), that we regarded as an upper bound, obtaining comparable results.
E06-1003
Based Lexical Entailment Dagan et al.(2006) adapted the classical supervised WSD setting to approach the sense matching problem (i.e., the binary lexical entailment problem of deciding whether a word, such as position, entails a different word, such as job, in a given context) by defining a one-class learning algorithm based on support vector machines (SVM).
P06-1057
We used a standard feature set inspired by the literature on text chunking and NER (Tjong Kim Sang and Buchholz, 2000; Tjong Kim Sang and De Meulder, 2003; Tjong Kim Sang, 2002) to train a first-order CRFs.
W00-0726 W02-2024 W03-0419
Fleischman and Hovy (2002) approached the ontology population problem as a classification task, providing examples of instances in their context as training examples for their respective fine-grained categories.
C02-1130
Dagan. 2006a.
P06-1057
First of all, it allows us to provide both positive and negative examples, avoiding the use of one-class classification algorithms that in practice perform poorly (Dagan et al., 2006).
P06-1057
Therefore, approaches based on a more classical contextual similarity technique (Lin, 1998; Dagan, 2000), where words are described “globally” by context vectors, are doomed to fail.
P98-2127
Therefore, most of the present research in ontology population is focusing on either unsupervised approaches (Cimiano and V¨olker, 2005) or weakly supervised approaches (Tanev and Magnini, 2006).
E06-1003
5In (Gliozzo et al., 2005), in addition to the standard VSM, a domain kernel, exploiting external information acquired from unlabeled data, has been also used to reduce the amount of (labeled) training data.
P05-1050
Of course providing such set could be problematic in many cases (e.g., it could be incomplete or simply not available for 2This approach resembles the pseudo-words technique proposed to evaluate WSD algorithms at the earlier stages of the WSD studies (Gale et al., 1992), when large scale sense tagged corpora were not available for training supervised algorithms.
H92-1045
Then we evaluate our technique by comparing it to state-of-the-art unsupervised approaches for ontology population (Section 5.2). 5.1 Experimental Settings For all experiments, we adopted the evaluation benchmark proposed in (Tanev and Magnini, 2006).
E06-1003
The state-of-the-art supervised WSD methodology, reporting the best results in most of the Senseval-3 lexical sample tasks in different languages, is based on a combination of syntagmatic and domain kernels (Gliozzo et al., 2005) in a SVM classification framework.
P05-1050
Contextual similarity has been measured by adopting lexico-syntactic features provided by a dependency parser, as proposed in (Lin, 1998).
P98-2127
We refer to (Gliozzo et al., 2005) for a detailed description of the domain kernel.
P05-1050
In the literature, slight variations of this problem are also referred to as sense matching (Dagan et al., 2006), lexical reference (Glickman et al., 2006a) and lexical substitution (Glickman et al., 2006b).
P06-1057 W06-1621 W06-2907
In general, the strategy adopted to model syntagmatic relations in WSD is to provide bigrams and trigrams ofcollocatedwordsasfeaturestodescribelocalcontexts (Yarowsky, 1994).
P94-1013
