An interesting research thread is to use more linguistic structure in a statistical translation model [Yamada and Knight 2001], which has some relevance to ITU since we need to handle structured semantic data.
P01-1067
2 MDA: A semantics-based document authoring system The MDA (Multilingual Document Authoring) system [Brun et al 2000] is an instance (descended from Ranta’s Grammatical Framework [Ranta 2002]) of a text-mediated interactive natural language generation system, a notion introduced by [Power and Scott 1998] under the name of WYSIWYM.
P98-2173 W00-1404
Computational Linguistics 19(2), 1993 [Brun, Dymetman and Lux 2000].
W00-1404
Pogodalla. References [Berger and Lafferty 1999] Information Retrieval as Statistical Translation, SIGIR-99 [Brown, Della Pietra, Della Pietra and Mercer 1993] The Mathematics of Statistical Machine Translation: Parameter Estimation.
J93-2003
document normalization to ITU A first route towards achieving an ITU system is through an extension of ongoing work on document normalization [Max and Dymetman 2002, Max 2003].
E03-3006
[Yamada and Knight 2001] A Syntax-based Translation Model, ACL-01 .
P01-1067
[Foster, Langlais and Lapalme, 2002] User-Friendly Text Prediction for Translators, EMNLP-02 [Knight and Marcu 2002] Summarization beyond sentence extraction: A Probabilistic Approach to Sentence Compression, Artificial Intelligence, 139(1), 2002.
W02-1020
[Och and Ney 2002] Discriminative Training and Maximum Entropy Models for Statistical Machine Translation, ACL02 [Power and Scott 1998] Multilingual Authoring using Feedback Texts.
P02-1038 P98-2173
He then goes on to adapt the conventional noisy channel MT model of [Brown et al 1993] to NLU, where extracting a semantic representation from an input text corresponds to finding: argmax(Sem) {p(Input|Sem) p(Sem)}, where p(Sem) is a model for generating semantic representations, and p(Input|Sem) is a model for the relation between semantic representations and corresponding texts.
J93-2003
[Max and Dymetman 2002] Document Content Analysis through Fuzzy Inverted Generation, in AAAI 2002 Spring Symposium on Using (and Acquiring) Linguistic (and World) Knowledge for Information Access, 2002 [Max 2003].
E03-3006
statistical ITU Recent research on the interactive statistical machine translation system TransType [Foster et al, 1997; Foster et al, 2002] holds special interest in relation to ITU.
W02-1020
4, we see strong parallels between TransType and ITU: language model enumerating word sequences vs 4 Initially statistical MT used a noisy-channel approach [Brown et al.1993]; but recently [Och and Ney 2002] have introduced a more general framework based on the maximum-entropy principle, which shows nice prospects in terms of flexibility and learnability.
J93-2003 P02-1038
