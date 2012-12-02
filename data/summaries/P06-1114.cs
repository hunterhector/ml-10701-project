(Harabagiu et al., 2001; Moldovan et al., 2002)); (2) a combination of language processes that transform questions and candidate answers in logic representations such that reasoning systems can select the correct answer based on their proofs (cf.
P01-1037 P02-1005
(Prager et al., 2004)).
P04-1073
In order to provide a baseline for our experiments, we ran a version of our Q/A system, known as FERRET (Harabagiu et al., 2005a), that does not make use of textual entailment information when identifying answers to questions.
P05-1026
While probabilistic or web-based methods for answer validation have been previously explored in the literature (Magnini et al., 2002), these approaches have modeled the relationship between a question and a (correct) answer in terms of relevance and have not tried to approximate the deeper semantic phenomena that are involved in determining answerhood.
P02-1054
Classi er Training Set Precision Recall F-Measure Linear 10K pairs 0.837 0.774 0.804 Maximum Entropy 10K pairs 0.881 0.851 0.866 Maximum Entropy 450K pairs 0.902 0.944 0.922 Table 4: Performance of Alignment Classi er 3.2 Paraphrase Acquisition Much recent work on automatic paraphrasing (Barzilay and Lee, 2003) has used relatively simple statistical techniques to identify text passages that contain the same information from parallel corpora.
N03-1003
(Echihabi and Marcu, 2003)); or (4) a constraint satisfaction problem, where sets of auxiliary questions are used to provide more information and better constrain the answers to individual questions (cf.
P03-1003
In previous work (Harabagiu et al., 2005b), we have described techniques that can be used to automatically generate well-formed natural language questions from the text of paragraphs retrieved by a PR module.
P05-1026
(Moldovan et al., 2003)); (3) a noisy-channel model which selects the most likely answer to a question (cf.
N03-1022
Features derived from the entailment con dence were then combined with the keywordand relation-based features described in (Harabagiu et al., 2005a) in order to produce a nal ranking of candidate answers.
P05-1026
Following an idea proposed in (Burger and Ferro, 2005), we created a corpus of approximately 101,000 textual entailment examples by pairing the headline and rst sentence from newswire documents.
W05-1209
In order increase the likelihood that 909 only true paraphrases were considered as phraselevel alternations for an example, extracted sentences were clustered using complete-link clustering using a technique proposed in (Barzilay and Lee, 2003).
N03-1003
diamondmath2diamondmath UNALIGNED CHUNK: This feature represents the number of chunks in one text that are not aligned with a chunk from the other diamondmath3diamondmath LEXICAL ENTAILMENT PROBABILITY: This feature is de ned in (Glickman and Dagan, 2005).
W05-1208
