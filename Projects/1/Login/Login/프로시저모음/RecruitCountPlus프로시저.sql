-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		권희경
-- Create date: 2020-06-26
-- Description:	구직글 조회수 증가 프로시저
-- =============================================
CREATE PROCEDURE RecruitCountPlus
	@w_num int
AS
BEGIN
	
	update RECRUIT set COUNT = COUNT+1 where W_NUM = @w_num;
END
GO
