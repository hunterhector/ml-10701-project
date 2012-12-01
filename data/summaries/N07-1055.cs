Like Barzilay and Lee (2004), we learn an HMM in which each sentence has a hidden topic qi, which is chosen conditioned on the previous state qi−1.
N04-1015
On the other hand, the wider variety of grammatical constructions used may motivate more complex syntactic features, for instance as proposed by (Siddharthan et al., 2004) in sentence clustering.
C04-1129
Their mixture includes an entity grid model and a version of the HMM of (Barzilay and Lee, 2004), which uses n-gram language modeling.
N04-1015
Properly speaking entities may be referents of many different nouns and pronouns throughout the discourse, and both (Lapata and Barzilay, 2005) and (Barzilay and Lapata, 2005) present models which use coreference resolution systems to group nouns.
P05-1018
(Barzilay and Lee, 2004), which lacks local features, does quite poorly on this task (74%), while our model performs extremely well (94%).
N04-1015
Barzilay and Lapata (2005) uses the same grid representation, but treats the transition probabilities P(ri,j|vectorri,j) for each document as features for input to an SVM classifier.
P05-1018
This task bears some resemblance to the task of discriminating coherent from incoherent essays in (Miltsakaki and Kukich, 2004), and is also equivalent in the limit to the ranking metric of (Barzilay and Lee, 2004), which we cannot calculate because our model does not produce k-best output.
N04-1015
Entity Grids Entity grids, first described in (Lapata and Barzilay, 2005), are designed to capture some ideas of Centering Theory (Grosz et al., 1995), namely that adjacent utterances in a locally coherent discourses are likely to contain the same nouns, and that important nouns often appear in syntactically important roles such as subject or object.
J95-2003 P05-1018
Our combined model uses only entity-grid features and unigram language models,a strict subset of the feature set of (Soricut and Marcu, 2006).
P06-2103
Unlike Barzilay and Lee (2004), we do not initialize with an informative starting distribution.
N04-1015
As the local component of our model we adapt (Barzilay and Lapata, 2005) by relaxing independence assumptions so that it is effective when estimated generatively.
P05-1018
Unlike the mixture model of (Soricut and Marcu, 2006), we learn local and global features jointly, providing a better theoretical explanation of how they are useful.
P06-2103
The HMM content model of (Barzilay and Lee, 2004), which does have global structure, performs much better on ordering, at τ of .44.
N04-1015
Models of coherent discourse are central to several tasks in natural language processing: such models have been used in text generation (Kibble and Power, 2004) and evaluation of human-produced text in educational applications (Miltsakaki and Kukich, 2004; Higgins et al., 2004).
J04-4001 N04-1024
c©2007 Association for Computational Linguistics A Unified Local and Global Model for Discourse Coherence Micha Elsner, Joseph Austerweil, and Eugene Charniak Brown Laboratory for Linguistic Information Processing (BLLIP) Brown University Providence, RI 02912 {melsner,ec}@cs.brown.edu, joseph.austerweil@gmail.com Abstract We present a model for discourse coherence which combines the local entitybased approach of (Barzilay and Lapata, 2005) and the HMM-based content model of (Barzilay and Lee, 2004).
N04-1015 P05-1018
In contrast, the global HMM model of Barzilay and Lee (2004) tries to track the predictable changes in topic between sentences.
N04-1015
To model transitions in this entity grid model, Lapata and Barzilay (2005) takes a generative approach.
P05-1018
Our global model is an HMM like that of Barzilay and Lee (2004), but with emission probabilities drawn from the entity grid.
N04-1015
Moreover, since our model is not Markovian, the relaxation used as a heuristic for A∗ search by Soricut and Marcu (2006) is ineffective.
P06-2103
Previous work by Soricut and Marcu (2006) has also attempted to integrate local and global features using a mixture model, with promising results.
P06-2103
Moreover, an accurate model can reveal information about document structure, aiding in such tasks as supervised summarization (Barzilay and Lapata, 2005).
P05-1018
Our local features are based on the entity grid model of (Barzilay and Lapata, 2005; Lapata and Barzilay, 2005).
P05-1018
Local models (Lapata, 2003; Barzilay and Lapata, 2005; Foltz et al., 1998) attempt to capture the generalization that adjacent sentences often have similar content, and therefore tend to contain related words.
P03-1069 P05-1018
Using both sets of features, our topic-based model achieves state of the art performance (τ = .5) on the ordering task, comparable with the mixture model of (Soricut and Marcu, 2006).
P06-2103
Like Lapata and Barzilay (2005), our relaxed model assigns low probability to sentences where nouns with important-seeming histories do not appear.
P05-1018
Ordering In the sentence ordering task, (Lapata, 2003; Barzilay and Lee, 2004; Barzilay and Lapata, 2005; Soricut and Marcu, 2006), we view a document as an unordered bag of sentences and try to find the ordering of the sentences which maximizes coherence according to our model.
N04-1015 P03-1069 P05-1018 P06-2103
Our model performs the ordering task competitively with (Soricut and Marcu, 2006), and significantly better than either of the models it is based on.
P06-2103
6Soricut and Marcu (2006) do not report results on this task, except to say that their implementation of the entity grid performs comparably to (Barzilay and Lapata, 2005).
P05-1018 P06-2103
Our second task is the discriminative test used by (Barzilay and Lapata, 2005).
P05-1018
Our search system has few Estimated Search Errors as defined by Soricut and Marcu (2006); it rarely proposes an ordering which has lower probaτ Discr.
P06-2103
Our experiments use the popular AIRPLANE corpus, a collection of documents describing airplane crashes taken from the database of the National 440 Transportation Safety Board, used in (Barzilay and Lee, 2004; Barzilay and Lapata, 2005; Soricut and Marcu, 2006).
N04-1015 P05-1018 P06-2103
We follow (Soricut and Marcu, 2006) in dropping this component of the system, and treat each head noun as having an individual single referent.
P06-2103
This is theo1Roles are determined heuristically using trees produced by the parser of (Charniak and Johnson, 2005).
P05-1022
Soricut and Marcu (2006)’s implementation of the entity-based model also uses discriminative training.
P06-2103
Unfortunately, finding the optimal ordering according to a probabilistic model with local features is NP-complete and non-approximable (Althaus et al., 2004).
P04-1051
7Barzilay and Lapata (2005) do not report τ scores.
P05-1018
Moreover, since the model we describe uses a strict subset of the features used in the component models of (Soricut and Marcu, 2006), we suspect that adding it to the mixture would lead to still further improved results.
P06-2103
(%) (Barzilay and Lapata, 2005) 90 (Barzilay and Lee, 2004) .44 745 (Soricut and Marcu, 2006) .50 -6 Topic-based (relaxed) .50 94 Table 1: Results for AIRPLANE test data.
N04-1015 P05-1018 P06-2103
