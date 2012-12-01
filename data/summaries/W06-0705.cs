Entailment Following (Harabagiu and Hickl, 2006), we used TE information in order to lter answers identi ed by the Q/A system that were not entailed by the user’s original question.
P06-1114 P06-4007
The architecture of our TE system is presented in Figure 4.1 Pairs of texts are initially sent to a Preprocessing Module, which performs syntactic and semantic parsing of each sentence, resolves coreference, and annotates entities and predicates with a wide range of lexico-semantic and prag1For more information on the TE system described in this section, please see (Hickl et al., 2006b) and (Harabagiu and Hickl, 2006).
P06-1114 P06-4007
When using contextual entailment for selecting question decompositions, we rely on the method reported in (Harabagiu et al., 2006) which generates questions by using a random walk on a bipartite graph of salient relations and answers.
P06-1114
Scenario knowledge was also included in the form of axiomatic logic transformation developed in (Moldovan et al., 2003).
N03-1022
Following work in (Hickl et al., 2004), we believe complex questions can be answered in one of two ways: either by (1) using techniques (similar to the ones proposed in (Harabagiu et al., 2006)) for automatically decomposing complex questions into sets of informationally-simpler questions, or by (2) using a multi-document summarization (MDS) system (such as the one described in (Lacatusu et al., 2006)) in order to assemble a ranked list of passages which contain information that is potentially relevant to the user’s question.
P06-1114 W04-2508
We show that by using a state-of-the-art textual entailment system (Hickl et al., 2006b), we can provide Q/A systems with another mechanism for approximating the inference between questions and relevant answers.
P06-4007
While (Harabagiu et al., 2005) used topic signatures (Lin and Hovy, 2000; Scenario Description The customer has commissioned a research project looking at the impact of the outsourcing of American jobs on the United States’ relationship with India.
C00-1072 P05-1026
Questions used in these experiments were gathered from human interactions with the interactive Q/A system described in (Hickl et al., 2006a).
P06-4007
results of such knowledge integration in a Q/A system against the usage of scenario knowledge reported in (Harabagiu et al., 2005).
P05-1026
c©2006 Association for Computational Linguistics Using Scenario Knowledge in Automatic Question Answering Sanda Harabagiu and Andrew Hickl Language Computer Corporation 1701 North Collins Boulevard Richardson, Texas 75080 USA sanda@languagecomputer.com Abstract This paper describes a novel framework for using scenario knowledge in opendomain Question Answering (Q/A) applications that uses a state-of-the-art textual entailment system (Hickl et al., 2006b) in order to discover textual information relevant to the set of topics associated with a scenario description.
P06-4007
For each such answer, one or multiple questions were built automatically with the method reported in (Harabagiu et al., 2005).
P05-1026
Textual Entailment Recent work in computational semantics (Haghighi et al., 2005; Hickl et al., 2006b; MacCartney et al., 2006) has demonstrated the viability of supervised machine learning-based approaches to the recognition of textual entailment (TE).
H05-1049 N06-1006 P06-4007
Harabagiu, 2004) computed automatically from collections of documents relevant to a scenario in order to approximate the semantic content of a scenario, (Narayanan and Harabagiu, 2004) employed formal models of the interrelated events, actions, states, and relations implicit to a scenario in order to produce ne-grained, contextsensitive inferences that could be used to answer questions.
C04-1084 C04-1100
While these approaches have not incorporated the forms of structured world knowledge featured in many logic-based TE systems, classi cation-based approaches have been consistently among the top-performing systems in both the 2005 and 2006 PASCAL Recognizing Textual Entailment (RTE) Challenges (Dagan et al., 2005), with the best systems (such as (Hickl et al., 2006b)) correctly identifying instances of textual entailment more than 75% of the time.
P06-4007
sembled, topic signatures (Lin and Hovy, 2000; Harabagiu 2004) are computed which identify the set of topic-relevant concepts and relations between concepts that are found in the relevant set of documents.
C00-1072 C04-1084
