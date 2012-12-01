Mann and Yarowsky (2003) have proposed a Web based clustering technique relying on a feature space combining biographic facts and associated names, whereas Bagga and Baldwin (1998) have looked for coreference chains within each document, take the context of these chains for creating summaries about each entity and convert these summaries into a bag of words.
P98-1012
Here, we adopt the policy of ?one person per document??(all mentions of the ambiguous personal name in one web page are assumed to refer to the same personal entity in reality) as in Bagga & Baldwin (1998), Mann & Yarowsky (2003) and Gooi & Allan (2004).
P98-1012
Similar approachwas developedby (Bagga andBaldwin, 1998), who created first order context vectors that represent the instance in which the ambiguous name occurs.
P98-1012
Magnini. 2006.
W06-0504 W06-0504 W06-0504 W06-0504
105 2 Data sets and feature construction The data we have used for training our system were made available in the framework of the SemEval (task 13: Web People Search) competition (Artiles et al., 2007).
W07-2012
First, we seek to go beyond the kind of bag-ofwords features employed in earlier systems (Bagga & Baldwin, 1998; Gooi & Allan, 2004; Pedersen et al., 2005), and attempt to exploit deep semantic features beyond the work of Mann & Yarowsky (2003).
P98-1012
The goal of the Web People Search task (Artiles et al.2007) is to assign Web pages to groups, where each group contains all (and only those) pages that refer to one unique entity.
W07-2012
References Bar-Haim, R., Dagan, I., Dolan, B., Ferro, L., Giampiccolo, D., Magnini, B., et al.(2006). The Second PASCAL Recognising Textual Entailment Challenge.
W06-0504
As reported on an experiment carried out on an Italian news corpus (Magnini et all 2006) within a 4 consecutive days from a local newspaper the perplexity is 56% and 14% for first and last name respectively.
W06-0504
Inthispaper, wepresentanewtextsemanticsimilarityapproachforfine-grainedpersonnamecategorization and discrimination which is similar to those of (Pedersen et al., 2005) and (Bagga and Baldwin, 1998), but instead of simple word co-occurrences, we consider the whole text segment and relate the deduced semantic information of Latent Semantic Analysis (LSA) to trace the text cohesion between thousands of sentences containing named entities which belong to different fine-grained categories or individuals.
P98-1012
Bagga A., Baldwin B.,(1998) Entity-Based cross-document-referencing using vector space model, In proceedings of 17th International Conference on Computational Linguistics Magnini B., Pianta E., Popescu O.
P98-1012
extraction and similarity matrix learning Most of the previous work (Bagga & Baldwin, 1998; Gooi & Allan; 2004; Pedersen et al., 2005) uses token information in the given documents.
P98-1012
(Tanev and Magnini, 2006) classified geographic location and person names into several subclasses.
W06-0504
(Kouylekov and Magnini, 2006) explore a syntactic tree editing distance to detect entailment relations.
W06-0504
Although the clustering results with the best settings for hierarchical and agglomerative clustering were very close with regard to F-score (combining purity and inverse purity, see (Artiles et al., 2007) for a more detailed description), manual inspection of the content of the clusters has revealed big differences between the two approaches.
W07-2012
An early work in name disambiguation (Bagga and Baldwin, 1998) uses the similarity between documents in a Vector Space using a ?bag of words?? representation.
P98-1012
Our proposal is to rely on special N-grams for coreference and it is a variant of agglomerative clustering based on social networks(Bagga&Baldwin 1998, Malin 2005). The terms the N-grams contain are crucial.
P98-1012
Simultaneously, multiple identical mentions refer to distinct entities (Bagga and Baldwin, 1998).
P98-1012
There are two results in Table 1: One is gotten from the evaluation of Semeval Web People Track (SemEval), and the other is evaluated with B-cubed evaluation (Bagga and Baldwin, 1998).
P98-1012
Our system was not built specifically for the web people search task WePS (Artiles et al., 2007), but is an early version of an IE system that has the more general goal to discover relations between NEs.
W07-2012
Names are ambiguous items (Artiles, Gonzalo and Sekine 2007).
W07-2012
Instead it will presentsomeworkinprogressthattriestomodelthe probability of entailment in terms of ideas motivated by approaches like the edit-distance (Kouylekov and Magnini, 2005; Kouylekov and Magnini, 2006; Tatu et al., 2006; Adams, 2006).
W06-0504
