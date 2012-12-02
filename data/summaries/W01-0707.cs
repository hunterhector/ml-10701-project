The segmentation into nuclei relies on a manually built chunker, similar to the one described in (Ait-Mokhtar and Chanod, 1997), and resembles the one proposed in (Samuelsson, 2000).
A97-1012 C00-2099
Apart from this difference, model C directly relies on a combination of equations (10) and (12), namely conditioning by a80a7a81a49a82a9a12, a74a61a8a65a75a57a12 and a74a61a8a65a75a57a14a61a86, both the probability of generating a74a61a8a65a75 a47 and the one of generating a80a7a81a49a82 a47 . Thus, model C uses a reduced version of equation (12) and an extended version of 2Other models, as (Collins and Brooks, 1995; Merlo et al., 1998) for PP-attachment resolution, or (Collins, 1997; Samuelsson, 2000) for probabilistic parsing, are somewhat related, but their supervised nature makes any direct comparison impossible.
C00-2099 P97-1003 W95-0103 W97-0317
Vilain. 1998.
P98-2234
From the models proposed in (Eisner, 1996), we retain only the model referred to as model C in this work, since the best results were obtained with it.
C96-1058
The model proposed in (Ratnaparkhi, 1998) is similar to a version of our model based solely on equation (9), with no semantic information.
P98-2177
The proposed model was used to assign probability estimates to dependency links between nuclei in our own implementation of the parser described in (Eisner, 1996).
C96-1058
The results obtained in previous works relying on semantic classes are above ours (around 0.82 3This huge number of tokens can be explained by the fact that the lexicon used for tokenization and tagging integrates many multi-word expressions which are not part of the semantic lexicon for (Brill and Resnik, 1994) and 0.77 for (Lauer and Dras, 1994)), but a direct comparison is difficult inasmuch as only three-word sequences (V N P, for (Brill and Resnik, 1994) and N N N for (Lauer and Dras, 1994)) were used for evaluation in those works, and the language studied is English.
C94-2195
This extension could be used in our case too, but, since the input to our processing chain consists of tagged words (unless the input of the stochastic dependency parser of (Eisner, 1996)), we do not think it necessary.
C96-1058
A second model relevant to our discussion is the one proposed in (Ratnaparkhi, 1998), addressing the problem of unsupervised learning for PP attachment resolution in VERB NOUN PP sequences.
P98-2177
In order to avoid sparse data problems, we make the simplifying assumption (similar to the one presented in (Eisner, 1996)) that the attachment of nucleus a5a28a51 a6 to nucleus a5 a0a7a6 depends only on the set of indices of the preceding dependency relations (in order to avoid cycles and crossing dependencies) and on the three nuclei a5a28a51 a6, a5 a0a7a6 and a5a52a22 a47 a6, where a5a53a22 a47 a6 denotes the last nucleus being attached to a5 a0a7a6 . a5a53a22 a47 a6 is thus the closest sibling of a5a28a51 a6 . Conditioning attachment on it the attachment of a5a28a51 a6 allows capturing the fact that the object of a verb may depend on its subject, that the indirect object may depend on the direct object, and other similar indirect dependencies.
C96-1058
For more details concerning the parser, see (Eisner, 1996).
C96-1058
Lastly, the results we obtained are similar to the ones obtained by different authors on a similar task, as (Ratnaparkhi, 1998; Hindle and Rooth, 1993; Brill and Resnik, 1994) for example.
C94-2195 J93-1005 P98-2177
In fact, by adding to the set of prepositions an empty preposition, a101, the counts of which are estimated from unsafe configurations (that is a74a19a5a53a102a103a81a49a72a85a104 a6a21a32a106a105a108a107a19a109a83a110a2a107 a74a19a5a52a102a39a81a19a72a85a104a85a16a7a26a73a72a85a81a59a26 a6a38a111 a74a19a5a53a102a103a81a49a72a85a104a85a16a112a101 a6 ), equation (9) captures both the contribution from the random variable used in (Ratnaparkhi, 1998) to denote the presence or absence of any preposition that is unambiguously attached to the noun or the verb in question, and the contribution from the conditional probability that a particular preposition will occur as unambiguous attachment to the verb or to the noun.
P98-2177
