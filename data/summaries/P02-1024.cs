Many traditional clustering techniques [Brown et al., 1992] attempt to maximize the average mutual information of adjacent clusters ∑ = 21, 2 12 2121 )( )|( log)(),( WW WP WWP WWPWWI, (2) where the same clusters are used for both predicted and conditional words.
J92-4003
The n-gram model has been widely applied in many applications such as speech recognition, machine translation, and Asian language text input [Jelinek, 1990; Brown et al., 1990; Gao et al., 2002].
J90-2002
Saul and Pereira [1997] demonstrated the utility of soft clustering and concluded that any method that assigns each word to a single cluster would lose information.
W97-0309
Work A large amount of previous research on clustering has been focused on how to find the best clusters [Brown et al., 1992; Kneser and Ney, 1993; Yamamoto and Sagisaka, 1999; Ueberla, 1996; Pereira et al., 1993; Bellegarda et al., 1996; Bai et al., 1998].
J92-4003 P93-1024
One area we have not explored is the use of soft clustering, where a word w can be assigned to multiple clusters W with a probability P(W|w) [Pereira et al., 1993].
P93-1024
Recent research [Yamamoto et al., 2001] shows that using different clusters for predicted and conditional words can lead to cluster models that are superior to classical cluster models, which use the same clusters for both words [Brown et al., 1992].
J92-4003 P01-1068
Although similar models have been used in previous studies [Goodman and Gao, 2000; Yamamoto et al., 2001], several issues have not been completely investigated.
P01-1068
