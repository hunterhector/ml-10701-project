These features are top-level semantic categories from a three-level general taxonomy for Chinese nouns, which was created semi-automatically based on two Chinese semantic dictionaries (Chen and Palmer, 2004).
P04-1038
Dang and Palmer (2005) also use predicate-argument information as features in their work on English verbs, but their argument labels are not produced by an automatic SRL system.
J05-1004 P05-1006
Rather, their semantic role labels are directly extracted from a human annotated 926 corpus, the English Proposition Bank (Palmer et al, 2005), citing the inadequate accuracy of automatic semantic role labeling systems.
J05-1004
Our work is more closely related to the work of Dang et al (2002), who conducted experiments on 28 verbs and achieved an accuracy of 94.2%.
C02-1143
Niu et al (2004) applied a Naive Bayesian model to Chinese WSD and experimented with different window sizes for extracting local and topical features and different types of local features (e.g., bigram templates, local words with position or parts-ofspeech information).
W04-0847
Results The data we used for our experiments are developed as part of the OntoNotes project (Hovy et al., 2006) and they come from a variety of sources.
N06-2015
This model has been applied successfully for English WSD (Dang, 2004; Chen and Palmer, 2005).
J05-1004 P05-1006
For example, the sense annotation component of the OntoNotes project (Hovy, et al., 2006) attempts to create a large-scale coarsegrained sense-annotated corpus with senses defined based on explicit linguistic criteria.
N06-2015
This supports previous arguments for word-specific feature design and parametric modeling for WSD tasks (Chen and Palmer, 2005; Hoste et al.2002). We report experiments on ten highly polysemous Chinese verbs and show that features are not uniformly useful for all words.
J05-1004
However, this result assumes the human annotation of the Penn English Propbank (Palmer et al, 2005).
J05-1004
Li et al.(2005) used sense-tagged true bigram collocations 2 as features.
I05-3012
Even for these verbs, the majority of them are not difficult to disambiguate, based on work by Dang et al.(2002). Only a small number of these verbs truly need customized features.
C02-1143
Comparison with Our English WSD System Similar to our English WSD system, which achieved the best published results on SENSEVAL2 English verbs for both finegrained and coarse-grained senses (Chen and Palmer, 2005), our Chinese WSD system uses the same smoothed MaxEnt machine learning model and linguistically motivated features for Chinese verb sense disambiguation.
J05-1004
To that end, we assigned semantic role labels to the arguments of the target verb with a fully automatic semantic role tagger (Xue and Palmer, 2005) trained on the Chinese Propbank (CPB) (Xue and Palmer, 2003), a corpus annotated with semantic role labels that are similiar in style to the Penn English Propbank.
J05-1004 W03-1707
Based on Automatic Semantic Role Tagging In a recent paper on the WSD of English verbs, Dang and Palmer (2005) showed that semantic role information significantly improves the WSD accuracy of English verbs for both fine-grained and coarse-grained senses.
J05-1004 P05-1006
The top five verbs are verbs that were identified as difficult verbs in Dang et al�s (2002) experiments.
C02-1143
The English data used for the SENSEVAL exercises, arguably the most widely used data to train and test WSD systems, are annotated based on very fine-grained distinctions defined in WordNet (Fellbaum, 1998), with human inter-annotator agreement at a little over seventy percent and the top-ranked systems� performances falling between 60%~70% (Palmer, et al., 2001; Mihalcea et al., 2004).
W04-0807
