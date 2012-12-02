As in McCarthy (2000), the nouns are classified using WordNet.
A00-2034
Alternation Behavior Automatic clustering of co-occurrences of verbs and their direct objects was first used to induce semantically related classes of both verbs and nouns (Pereira et al., 1993).
P93-1024
We will examine maximum likelihood bigram and trigram models, clustering models based on those of Rooth et al.(1999), as well as a new probabilistic model designed to capture alternations in verb-argument structure.
P99-1014
A perspective on this work can be gained by comparison with attempts at unsupervised learning of other natural language phenomena including partof-speech tagging (Merialdo, 1994) and syntactic dependencies (Carroll and Charniak, 1992; Paskin, 2001).
J94-2001
For the verb play, on the other hand, classified as an “object-drop” verb by Merlo and Stevenson (2001), we would expect overlap between the subject of transitive and intransitive uses.
J01-3003
One of the clusters found by the model of Rooth et al.(1999) corresponded to “verb of scalar change” such as increase, rise,anddecrease.The model places both subject-of-intransitive-increase and direct-object-of-increase in this class, but does not explicitly capture the fact that these to values represent different uses of the same verb.
P99-1014
McCarthy (2000), Merlo and Stevenson (2001), and Schulte im Walde (2000) have evaluated their systems’ accuracy against human judgments of verb classification, with the comprehensive verb classes of Levin (1993) often serving as a gold standard.
A00-2034 J01-3003
This idea has been used by McCarthy (2000) to identify verbs participating in specific alternations by looking for overlap between nouns used in different positions, and by using WordNet to classify role fillers into semantic categories.
A00-2034
Function tags were assigned using a simple probability model trained on the Wall Street Journal data from the Penn Treebank, in a technique similar to that of Blaheta and Charniak (2000).
A00-2031
Another area of research has focused on automatic clustering algorithms for verbs and their arguments with the goal of finding groups of semantically related words (Pereira et al., 1993; Rooth et al., 1999), without focusing specifically on alternation behavior.
P93-1024 P99-1014
The model predicts the function tag conditioned on the verb and head noun of the noun phrase: C8B4CUCYDABND2B5BP B4 DI C8B4CUCYDABND2B5 B4DABND2B5 BE CC BD BE DI C8B4CUCYDAB5B7 BD BE DI C8B4CUCYD2B5 otherwise where CU ranges over the function tags defined (Marcus et al., 1994), or the null tag.
H94-1020
Direct object noun phrases were assigned the function tags of the Treebank-2 annotation style (Marcus et al., 1994) in order to distinguish noun phrases such as temporal adjuncts from true direct objects.
H94-1020
Rooth et al.(1999) used the Expectation Maximization algorithm to perform soft clustering by optimizing the parameters of a fairly simple probability model, which considers the verb and noun to be independent given the unobserved cluster variable CR: C8B4DABND2B5BP CG CR C8B4CRB5C8B4DACYCRB5C8B4D2CYCRB5 In Rooth et al.(1999), the variable DA represented not only the lexical verb but also its syntactic relation to the noun: either direct object, subject of an intransitive, or subject of a transitive verb.
P99-1014
Automatically derived word clusters are used in the statistical parsers of Charniak (1997) and Magerman (1995).
P95-1037
Verb-Slot Aspect: This is the model of Rooth et al.(1999), in which the verb and slot are combined into one atomic variable before the aspect model is trained: C8 CR DAD7 BP C8B4CRB5C8B4DABND7CYCRB5C8B4D2CYCRB5 Noun-Slot Aspect: A variation on the above model combines the slot with the noun, rather than the verb: C8 CR D2D7 BP C8B4CRB5C8B4DACYCRB5C8B4D2BND7CYCRB5 Alternation: This model, described in more detail above, introduces a new unobserved variable D6 for the semantic role of the noun, which can take two values: C8 CPD0D8 BP C8B4CRB5C8B4DACYCRB5C8B4D7CYCRB5C8B4D6CYD7BNCRB5C8B4D2CYD6BNCRB5 000000 000000 000000 000000 000000 111111 111111 111111 111111 111111 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 cluster verb slot noun 00000 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 11111 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 cluster verb,slot noun 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 verb noun slot role cluster 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 00000 00000 00000 00000 00000 11111 11111 11111 11111 11111 cluster verb noun,slot Alternation Verb-Slot AspectThree-way Aspect Noun-Slot Aspect Figure 1: Graphical models: shading represents observed variables, arrows probabilistic dependencies.
P99-1014
Language models based on head-modifier lexical dependencies in syntactic trees have been shown to have lower perplexity than D2-gram language models and to reduce word-error rates for speech recognition (Chelba and Jelinek, 1999; Roark, 2001).
J01-2004
3TheData For our experiments we used a version of the British National Corpus parsed with the statistical parser of Collins (1997).
P97-1003
