For example, the one sense per discourse principle is often used for word sense disambiguation (Gale et al.1992). In this research, we used the heuristic one tag per domain for multiword NE in addition to the one sense per discourse principle.
H92-1045
These include systems based on handcrafted rules (Krupka 1998), as well as systems using supervised machine learning, such as the Hidden Markov Model (HMM) (Bikel 1997) and the Maximum Entropy Model (Borthwick 1998).
A97-1029 M98-1015 M98-1018
(Cucchiarelli & Velardi 2001) discussed boosting the performance of an existing NE tagger by unsupervised learning based on parsing structures.
J01-1005
(Cucerzan & Yarowsky 1999), (Collins & Singer 1999) and (Kim 2002) presented various techniques using co-training schemes for NE extraction seeded by a small list of proper names or handcrafted NE rules.
C02-1088 W99-0612 W99-0613
The definitions of these features are the same as in (Bikel 1997).
A97-1029
The tag propagation/elimination scheme is adopted from (Yarowsky 1995).
P95-1026
We used the same blind testing corpus of 300,000 words containing 20,000 PER, LOC and ORG instances that were truthed in-house originally for benchmarking the existing supervised NE tagger (Srihari, Niu & Li 2000).
A00-1034
To derive the parsing-based learner, instead of seeding the bootstrapping process with NE instances from a proper name list or handcrafted NE rules as (Cucerzan & Yarowsky 1999), (Collins & Singer 1999) and (Kim 2002), the system only requires a few common noun or pronoun seeds that correspond to the concept for the targeted NE, e.g. he/she/man/woman for PERSON NE.
C02-1088 W99-0612 W99-0613
The HMM is defined as follows: Given a word sequence nn00 fwfwsequenceW G16= (where j f denotes a single token feature which will be defined below), the goal for the NE tagging task is to find the optimal NE tag sequence n210 ttttsequence T G16=, which maximizes the conditional probability sequence)W |sequence Pr(T (Bikel 1997).
A97-1029
The performance of our HMM tagger is comparable with the reported performance in (Collins & Singer 1999).
W99-0613
The rationale behind using concept-based seeds in NE bootstrapping is similar to that for parsingbased word clustering (Lin 1998): conceptually similar words occur in structurally similar context.
P98-2127
Lin, D.K. 1998.
P98-2127
The training process is similar to (Bikel 1997).
A97-1029
2002]. The InfoXtract parser supports dependency parsing based on the linguistic units constructed by our shallow parser (Srihari et al.2003). Five types of the decoded dependency relationships are used for parsing-based NE rule learning.
W03-0808
Before the bootstrapping is started, a large raw training corpus is parsed by the English parser from our InfoXtract system (Srihari et al.2003). The bootstrapping experiment reported in this paper is based on a corpus containing ~100,000 news articles and a total of ~88,000,000 words.
W03-0808
