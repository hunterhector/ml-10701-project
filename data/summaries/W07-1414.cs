on RTE3 data Since our contribution focuses on syntactic paraphrasing, our RTE3 system is a simplified version 86 Table 2: Percent accuracy on RTE3 set without paraphrasing (?? and with paraphrasing (+) Task Dev??Dev+ Test??Test+ IE 59.5 61.0 53.0 53.5 IR 67.0 68.0 58.5 61.5 QA 76.0 76.5 69.0 68.0 SUM 66.0 67.5 53.0 53.5 Overall 66.9 68.2 58.6 59.1 of our RTE2 system as described in (ref supressed for blind reviewing) The core of the system is still the tree alignment algorithm from (Meyers et al., 1996), but without normalization of node weights and applied to Minipar instead of Maltparser output.
C96-1078
As the text part may consist of more than one sentence, we first perform sentence splitting using Mxterminator (Reynar and Ratnaparkhi, 1997), a maximum 83 entropy-based end of sentence classifier trained on the Penn Treebank data.
A97-1004
Table 3: 2 billion word corpus statistics We have tokenized the text using the Grok-OpenNLP tokenizer (Morton, 2002) and split the sentences using MXTerminator (Reynar and Ratnaparkhi, 1997).
A97-1004
