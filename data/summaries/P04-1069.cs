We start with a technical result that was proven in (Abney et al., 1999; Chi, 1999; Nederhof and Satta, 2003).
J99-1004 P99-1070
Some first results on this issue have been presented by (Tendeau, 1995), who shows that the already mentioned left-corner parsing strategy can be extended probabilistically, and later by (Abney et al., 1999) who show that the pure top-down parsing strategy and a specific type of shift-reduce parsing strategy can be probabilistically extended.
P99-1070
Leermakers. 1989.
P89-1017
Furthermore, PLR parsing (Soisalon-Soininen and Ukkonen, 1979; Nederhof, 1994) can be expressed in our framework as a parsing strategy with the CPP and the SPP, and thus we obtain as a new result that this strategy allows probabilistic extension.
P94-1017
For example, (Sornlertlamvanich et al., 1999) and (Roark and Johnson, 1999) have shown that a probability distribution that can be obtained by training the probabilities of a CFG on the basis of a corpus can be less accurate than the probability distribution obtained by training the probabilities of a PDA constructed by a particular parsing strategy, on the basis of the same corpus.
P99-1054
These quantities can be computed to any degree of precision, as discussed for instance in (Booth and Thompson, 1973) and (Stolcke, 1995).
J95-2002
Furthermore, commonly used training algorithms for PCFGS/PPDAs always produce proper probability assignments, and many desired mathematical properties of these methods are based on such an assumption (Chi and Geman, 1998; S´anchez and Bened´ı, 1997).
J98-2005
However, the properness condition for PDAs has been heavily exploited in parsing applications, in doing incremental left-to-right probability computation for beam search (Roark and Johnson, 1999; Manning and Carpenter, 2000), and more generally in integration with other linear probabilistic models.
P99-1054
Probabilistic LR parsing has been investigated in the literature (Wright and Wrigley, 1991; Briscoe and Carroll, 1993; Inui et al., 2000) under the assumption that it would allow more fine-grained probability distributions than the underlying PCFGs.
J93-1002
Also the results from (Chitrao and Grishman, 1990), (Charniak and Carroll, 1994) and (Manning and Carpenter, 2000) could be seen in this light.
H90-1053
Related to LR parsing is ELR parsing (Purdom and Brown, 1981; Nederhof, 1994), which also lacks the SPP.
P94-1017
Furthermore, it has been shown in (Chi and Geman, 1998; S´anchez and Bened´ı, 1997) that a PCFG (G;pG) is consistent if pG was obtained by maximum-likelihood estimation using a set of derivations.
J98-2005
As discussed in the introduction, it has already been shown that for any PCFG G, there are equivalent PPDTs implementing these strategies, as reported in (Abney et al., 1999) and (Tendeau, 1995), respectively.
P99-1070
This observation gives rise to an extension with probabilities of the work on covers by (Nijholt, 1980; Leermakers, 1989).
P89-1017
