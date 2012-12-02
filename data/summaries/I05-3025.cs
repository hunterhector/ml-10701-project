Our word segmenter uses a maximum entropy framework (Ratnaparkhi, 1998; Xue and Shen, 2003) and is trained on manually segmented sentences.
W03-1728
Word Segmenter The Chinese word segmenter we built is similar to the maximum entropy word segmenter we employed in our previous work (Ng and Low, 2004).
W04-3236
Our implementation used the opennlp maximum entropy package v2.1.0 from sourceforge.1 1.1 Basic Features The basic features of our word segmenter are similar to our previous work (Ng and Low, 2004): (a) Cn(n = −2,−1,0,1,2) (b) CnCn+1(n = −2,−1,0,1) (c) C−1C1 (d) Pu(C0) (e) T(C−2)T(C−1)T(C0)T(C1)T(C2) In the above feature templates, C refers to a Chinese character.
W04-3236
